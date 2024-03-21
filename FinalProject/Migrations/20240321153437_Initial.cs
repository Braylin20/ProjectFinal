using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abogados",
                columns: table => new
                {
                    AbogadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColegioAbogadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abogados", x => x.AbogadoId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Sentencias",
                columns: table => new
                {
                    SentenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreMinisterio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentencias", x => x.SentenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemandaId = table.Column<int>(type: "int", nullable: false),
                    SentenciaId = table.Column<int>(type: "int", nullable: false),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Jueces",
                columns: table => new
                {
                    JuezId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SentenciaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jueces", x => x.JuezId);
                    table.ForeignKey(
                        name: "FK_Jueces_Sentencias_SentenciaId",
                        column: x => x.SentenciaId,
                        principalTable: "Sentencias",
                        principalColumn: "SentenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Demandas",
                columns: table => new
                {
                    DemandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SentenciaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demandas", x => x.DemandaId);
                    table.ForeignKey(
                        name: "FK_Demandas_Sentencias_SentenciaId",
                        column: x => x.SentenciaId,
                        principalTable: "Sentencias",
                        principalColumn: "SentenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demandas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expedientes",
                columns: table => new
                {
                    ExpedienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SentenciaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedientes", x => x.ExpedienteId);
                    table.ForeignKey(
                        name: "FK_Expedientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Niños",
                columns: table => new
                {
                    NinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombrePadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreMadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niños", x => x.NinoId);
                    table.ForeignKey(
                        name: "FK_Niños_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audiencias",
                columns: table => new
                {
                    AudienciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemandaId = table.Column<int>(type: "int", nullable: false),
                    FechaAudiencia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audiencias", x => x.AudienciaId);
                    table.ForeignKey(
                        name: "FK_Audiencias_Demandas_DemandaId",
                        column: x => x.DemandaId,
                        principalTable: "Demandas",
                        principalColumn: "DemandaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposDemandas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemandaId = table.Column<int>(type: "int", nullable: false),
                    NombreDemanda = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDemandas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposDemandas_Demandas_DemandaId",
                        column: x => x.DemandaId,
                        principalTable: "Demandas",
                        principalColumn: "DemandaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abogados",
                columns: new[] { "AbogadoId", "ColegioAbogadoId", "Nombre", "UsuarioId" },
                values: new object[,]
                {
                    { 1, null, "Juan Perez", 0 },
                    { 2, null, "Elizabeth Mata", 0 },
                    { 3, null, "Palito De Coco", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audiencias_DemandaId",
                table: "Audiencias",
                column: "DemandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandas_SentenciaId",
                table: "Demandas",
                column: "SentenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandas_UsuarioId",
                table: "Demandas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_UsuarioId",
                table: "Expedientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jueces_SentenciaId",
                table: "Jueces",
                column: "SentenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Niños_UsuarioId",
                table: "Niños",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDemandas_DemandaId",
                table: "TiposDemandas",
                column: "DemandaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abogados");

            migrationBuilder.DropTable(
                name: "Audiencias");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Expedientes");

            migrationBuilder.DropTable(
                name: "Jueces");

            migrationBuilder.DropTable(
                name: "Niños");

            migrationBuilder.DropTable(
                name: "TiposDemandas");

            migrationBuilder.DropTable(
                name: "Demandas");

            migrationBuilder.DropTable(
                name: "Sentencias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
