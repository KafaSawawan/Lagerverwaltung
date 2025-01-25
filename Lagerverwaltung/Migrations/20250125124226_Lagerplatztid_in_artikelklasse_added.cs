using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lagerverwaltung.Migrations
{
    /// <inheritdoc />
    public partial class Lagerplatztid_in_artikelklasse_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LagerplatzId",
                table: "Artikel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artikel_LagerplatzId",
                table: "Artikel",
                column: "LagerplatzId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikel_Lagerplatz_LagerplatzId",
                table: "Artikel",
                column: "LagerplatzId",
                principalTable: "Lagerplatz",
                principalColumn: "LagerplatzId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikel_Lagerplatz_LagerplatzId",
                table: "Artikel");

            migrationBuilder.DropIndex(
                name: "IX_Artikel_LagerplatzId",
                table: "Artikel");

            migrationBuilder.DropColumn(
                name: "LagerplatzId",
                table: "Artikel");
        }
    }
}
