using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Abogados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abogados",
                keyColumn: "AbogadoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abogados",
                keyColumn: "AbogadoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abogados",
                keyColumn: "AbogadoId",
                keyValue: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Abogados_UsuarioId",
                table: "Abogados",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abogados_Usuarios_UsuarioId",
                table: "Abogados",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abogados_Usuarios_UsuarioId",
                table: "Abogados");

            migrationBuilder.DropIndex(
                name: "IX_Abogados_UsuarioId",
                table: "Abogados");

            migrationBuilder.InsertData(
                table: "Abogados",
                columns: new[] { "AbogadoId", "ColegioAbogadoId", "Nombre", "UsuarioId" },
                values: new object[,]
                {
                    { 1, null, "Juan Perez", 0 },
                    { 2, null, "Elizabeth Mata", 0 },
                    { 3, null, "Palito De Coco", 0 }
                });
        }
    }
}
