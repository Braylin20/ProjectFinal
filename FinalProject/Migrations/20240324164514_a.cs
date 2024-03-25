using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlguacilId",
                table: "Demandas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Alguaciles",
                columns: table => new
                {
                    AlguacilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alguaciles", x => x.AlguacilId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demandas_AlguacilId",
                table: "Demandas",
                column: "AlguacilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandas_Alguaciles_AlguacilId",
                table: "Demandas",
                column: "AlguacilId",
                principalTable: "Alguaciles",
                principalColumn: "AlguacilId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandas_Alguaciles_AlguacilId",
                table: "Demandas");

            migrationBuilder.DropTable(
                name: "Alguaciles");

            migrationBuilder.DropIndex(
                name: "IX_Demandas_AlguacilId",
                table: "Demandas");

            migrationBuilder.DropColumn(
                name: "AlguacilId",
                table: "Demandas");
        }
    }
}
