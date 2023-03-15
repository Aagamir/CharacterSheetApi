using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class BodyLocations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyLocations_Armors_ArmorId",
                table: "BodyLocations");

            migrationBuilder.DropIndex(
                name: "IX_BodyLocations_ArmorId",
                table: "BodyLocations");

            migrationBuilder.DropColumn(
                name: "ArmorId",
                table: "BodyLocations");

            migrationBuilder.CreateTable(
                name: "ArmorBodyLocations",
                columns: table => new
                {
                    ArmorsId = table.Column<int>(type: "int", nullable: false),
                    BodyLocationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorBodyLocations", x => new { x.ArmorsId, x.BodyLocationsId });
                    table.ForeignKey(
                        name: "FK_ArmorBodyLocations_Armors_ArmorsId",
                        column: x => x.ArmorsId,
                        principalTable: "Armors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorBodyLocations_BodyLocations_BodyLocationsId",
                        column: x => x.BodyLocationsId,
                        principalTable: "BodyLocations",
                        principalColumn: "BodyLocationsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmorBodyLocations_BodyLocationsId",
                table: "ArmorBodyLocations",
                column: "BodyLocationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorBodyLocations");

            migrationBuilder.AddColumn<int>(
                name: "ArmorId",
                table: "BodyLocations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 0,
                column: "ArmorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 1,
                column: "ArmorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 2,
                column: "ArmorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 3,
                column: "ArmorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 4,
                column: "ArmorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 5,
                column: "ArmorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BodyLocations",
                keyColumn: "BodyLocationsId",
                keyValue: 6,
                column: "ArmorId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_BodyLocations_ArmorId",
                table: "BodyLocations",
                column: "ArmorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyLocations_Armors_ArmorId",
                table: "BodyLocations",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "Id");
        }
    }
}
