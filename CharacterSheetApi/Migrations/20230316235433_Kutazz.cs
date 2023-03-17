using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class Kutazz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Abilities_AbilitiesId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Armors_ArmorId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Equipments_EquipmentId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Skills_SkillsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Weapons_WeaponId",
                table: "CharacterInfos");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_AbilitiesId",
                table: "CharacterInfos");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_ArmorId",
                table: "CharacterInfos");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_EquipmentId",
                table: "CharacterInfos");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_SkillsId",
                table: "CharacterInfos");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_WeaponId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "AbilitiesId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "ArmorId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "CharacterInfos");

            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "Equipments",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CharacterInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AbilityCharacterInfo",
                columns: table => new
                {
                    AbilitiesId = table.Column<int>(type: "int", nullable: false),
                    CharacterInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityCharacterInfo", x => new { x.AbilitiesId, x.CharacterInfoId });
                    table.ForeignKey(
                        name: "FK_AbilityCharacterInfo_Abilities_AbilitiesId",
                        column: x => x.AbilitiesId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityCharacterInfo_CharacterInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharacterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorCharacterInfo",
                columns: table => new
                {
                    ArmorId = table.Column<int>(type: "int", nullable: false),
                    CharacterInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorCharacterInfo", x => new { x.ArmorId, x.CharacterInfoId });
                    table.ForeignKey(
                        name: "FK_ArmorCharacterInfo_Armors_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorCharacterInfo_CharacterInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharacterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInfoEquipment",
                columns: table => new
                {
                    CharacterInfoId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInfoEquipment", x => new { x.CharacterInfoId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_CharacterInfoEquipment_CharacterInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharacterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfoEquipment_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInfoSkill",
                columns: table => new
                {
                    CharacterInfoId = table.Column<int>(type: "int", nullable: false),
                    SkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInfoSkill", x => new { x.CharacterInfoId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_CharacterInfoSkill_CharacterInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharacterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfoSkill_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInfoWeapon",
                columns: table => new
                {
                    CharacterInfoId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInfoWeapon", x => new { x.CharacterInfoId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_CharacterInfoWeapon_CharacterInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharacterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfoWeapon_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityCharacterInfo_CharacterInfoId",
                table: "AbilityCharacterInfo",
                column: "CharacterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorCharacterInfo_CharacterInfoId",
                table: "ArmorCharacterInfo",
                column: "CharacterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfoEquipment_EquipmentId",
                table: "CharacterInfoEquipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfoSkill_SkillsId",
                table: "CharacterInfoSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfoWeapon_WeaponsId",
                table: "CharacterInfoWeapon",
                column: "WeaponsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityCharacterInfo");

            migrationBuilder.DropTable(
                name: "ArmorCharacterInfo");

            migrationBuilder.DropTable(
                name: "CharacterInfoEquipment");

            migrationBuilder.DropTable(
                name: "CharacterInfoSkill");

            migrationBuilder.DropTable(
                name: "CharacterInfoWeapon");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Equipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CharacterInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AbilitiesId",
                table: "CharacterInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArmorId",
                table: "CharacterInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "CharacterInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "CharacterInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_AbilitiesId",
                table: "CharacterInfos",
                column: "AbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_ArmorId",
                table: "CharacterInfos",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_EquipmentId",
                table: "CharacterInfos",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_SkillsId",
                table: "CharacterInfos",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_WeaponId",
                table: "CharacterInfos",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Abilities_AbilitiesId",
                table: "CharacterInfos",
                column: "AbilitiesId",
                principalTable: "Abilities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Armors_ArmorId",
                table: "CharacterInfos",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Equipments_EquipmentId",
                table: "CharacterInfos",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Skills_SkillsId",
                table: "CharacterInfos",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Weapons_WeaponId",
                table: "CharacterInfos",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id");
        }
    }
}
