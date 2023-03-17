using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateWeapon : Migration //WeaponCreator
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponCharacteristics_Weapons_WeaponId",
                table: "WeaponCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_WeaponCharacteristics_WeaponId",
                table: "WeaponCharacteristics");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "WeaponCharacteristics");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Weapons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "WeaponWeaponCharacteristics",
                columns: table => new
                {
                    WeaponCharacteristicsId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponWeaponCharacteristics", x => new { x.WeaponCharacteristicsId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_WeaponWeaponCharacteristics_WeaponCharacteristics_WeaponCharacteristicsId",
                        column: x => x.WeaponCharacteristicsId,
                        principalTable: "WeaponCharacteristics",
                        principalColumn: "WeaponCharacteristicsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponWeaponCharacteristics_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponWeaponCharacteristics_WeaponsId",
                table: "WeaponWeaponCharacteristics",
                column: "WeaponsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponWeaponCharacteristics");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "WeaponCharacteristics",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 0,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 1,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 2,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 3,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 4,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 5,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 6,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 7,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 8,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 9,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 10,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 11,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 12,
                column: "WeaponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeaponCharacteristics",
                keyColumn: "WeaponCharacteristicsId",
                keyValue: 13,
                column: "WeaponId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponCharacteristics_WeaponId",
                table: "WeaponCharacteristics",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponCharacteristics_Weapons_WeaponId",
                table: "WeaponCharacteristics",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id");
        }
    }
}
