using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Otra3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemandasUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Demandas_UsuarioId",
                table: "Demandas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandas_Usuarios_UsuarioId",
                table: "Demandas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandas_Usuarios_UsuarioId",
                table: "Demandas");

            migrationBuilder.DropIndex(
                name: "IX_Demandas_UsuarioId",
                table: "Demandas");

            migrationBuilder.CreateTable(
                name: "DemandasUsuarios",
                columns: table => new
                {
                    DemandaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandasUsuarios", x => new { x.DemandaId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_DemandasUsuarios_Demandas_DemandaId",
                        column: x => x.DemandaId,
                        principalTable: "Demandas",
                        principalColumn: "DemandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DemandasUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemandasUsuarios_UsuarioId",
                table: "DemandasUsuarios",
                column: "UsuarioId");
        }
    }
}
