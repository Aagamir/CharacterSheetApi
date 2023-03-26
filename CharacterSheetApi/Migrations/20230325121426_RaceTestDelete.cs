using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class RaceTestDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 0,
                column: "Name",
                value: "Human");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 1,
                column: "Name",
                value: "Elf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 2,
                column: "Name",
                value: "Dwarf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 3,
                column: "Name",
                value: "Hafling");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 0,
                column: "Name",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 1,
                column: "Name",
                value: "Human");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 2,
                column: "Name",
                value: "Elf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "RaceId",
                keyValue: 3,
                column: "Name",
                value: "Dwarf");

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "RaceId", "Name" },
                values: new object[] { 4, "Hafling" });
        }
    }
}
