using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class n : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "EstadosDemandas",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosDemandas", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoResoluciones",
                columns: table => new
                {
                    ResolucionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoResolcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoResoluciones", x => x.ResolucionId);
                });

            migrationBuilder.CreateTable(
                name: "TiposDemandas",
                columns: table => new
                {
                    TiposDemandasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDemanda = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDemandas", x => x.TiposDemandasId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "Sentencias",
                columns: table => new
                {
                    SentenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResolucionId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreMinisterio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentencias", x => x.SentenciaId);
                    table.ForeignKey(
                        name: "FK_Sentencias_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sentencias_TipoResoluciones_ResolucionId",
                        column: x => x.ResolucionId,
                        principalTable: "TipoResoluciones",
                        principalColumn: "ResolucionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Demandas",
                columns: table => new
                {
                    DemandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiposDemandasId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demandas", x => x.DemandaId);
                    table.ForeignKey(
                        name: "FK_Demandas_EstadosDemandas_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadosDemandas",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demandas_TiposDemandas_TiposDemandasId",
                        column: x => x.TiposDemandasId,
                        principalTable: "TiposDemandas",
                        principalColumn: "TiposDemandasId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_Abogados_Usuarios_UsuarioId",
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
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
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
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Demandados",
                columns: table => new
                {
                    DemandadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemandaId = table.Column<int>(type: "int", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demandados", x => x.DemandadoId);
                    table.ForeignKey(
                        name: "FK_Demandados_Demandas_DemandaId",
                        column: x => x.DemandaId,
                        principalTable: "Demandas",
                        principalColumn: "DemandaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpedientesDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpedienteId = table.Column<int>(type: "int", nullable: false),
                    SentenciaId = table.Column<int>(type: "int", nullable: false),
                    DemandaId = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedientesDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ExpedientesDetalles_Demandas_DemandaId",
                        column: x => x.DemandaId,
                        principalTable: "Demandas",
                        principalColumn: "DemandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpedientesDetalles_Expedientes_ExpedienteId",
                        column: x => x.ExpedienteId,
                        principalTable: "Expedientes",
                        principalColumn: "ExpedienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpedientesDetalles_Sentencias_SentenciaId",
                        column: x => x.SentenciaId,
                        principalTable: "Sentencias",
                        principalColumn: "SentenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abogados_UsuarioId",
                table: "Abogados",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Audiencias_DemandaId",
                table: "Audiencias",
                column: "DemandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandados_DemandaId",
                table: "Demandados",
                column: "DemandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandas_EstadoId",
                table: "Demandas",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandas_TiposDemandasId",
                table: "Demandas",
                column: "TiposDemandasId");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_UsuarioId",
                table: "Expedientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedientesDetalles_DemandaId",
                table: "ExpedientesDetalles",
                column: "DemandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedientesDetalles_ExpedienteId",
                table: "ExpedientesDetalles",
                column: "ExpedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedientesDetalles_SentenciaId",
                table: "ExpedientesDetalles",
                column: "SentenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Niños_UsuarioId",
                table: "Niños",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentencias_EmpleadoId",
                table: "Sentencias",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentencias_ResolucionId",
                table: "Sentencias",
                column: "ResolucionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abogados");

            migrationBuilder.DropTable(
                name: "Audiencias");

            migrationBuilder.DropTable(
                name: "Demandados");

            migrationBuilder.DropTable(
                name: "ExpedientesDetalles");

            migrationBuilder.DropTable(
                name: "Niños");

            migrationBuilder.DropTable(
                name: "Demandas");

            migrationBuilder.DropTable(
                name: "Expedientes");

            migrationBuilder.DropTable(
                name: "Sentencias");

            migrationBuilder.DropTable(
                name: "EstadosDemandas");

            migrationBuilder.DropTable(
                name: "TiposDemandas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "TipoResoluciones");
        }
    }
}
