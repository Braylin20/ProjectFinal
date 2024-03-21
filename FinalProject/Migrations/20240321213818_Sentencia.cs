using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Sentencia : Migration
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

            migrationBuilder.DropColumn(
                name: "SentenciaId",
                table: "Expedientes");

            migrationBuilder.AlterColumn<int>(
                name: "SentenciaId",
                table: "Sentencias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ExpedienteId",
                table: "Sentencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Sentencias_Expedientes_SentenciaId",
                table: "Sentencias",
                column: "SentenciaId",
                principalTable: "Expedientes",
                principalColumn: "ExpedienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sentencias_Expedientes_SentenciaId",
                table: "Sentencias");

            migrationBuilder.DropColumn(
                name: "ExpedienteId",
                table: "Sentencias");

            migrationBuilder.AlterColumn<int>(
                name: "SentenciaId",
                table: "Sentencias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SentenciaId",
                table: "Expedientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Abogados",
                columns: new[] { "AbogadoId", "ColegioAbogadoId", "Nombre", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 234, "Juan Perez", 0 },
                    { 2, 233, "Elizabeth Mata", 0 },
                    { 3, 231, "Palito De Coco", 0 }
                });
        }
    }
}
