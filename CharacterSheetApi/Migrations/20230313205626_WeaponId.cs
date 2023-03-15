using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class WeaponId : Migration
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
                name: "FK_CharacterInfos_BaseStats_BaseStatsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CharacterDescriptions_CharacterDescriptionId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Equipments_EquipmentId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_ExpiriencePoints_ExpiriencePointsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_GrowthStats_GrowthStatsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_LastClass_LastClassId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_MonetaryWealth_MonetaryWealthId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_PlayerInfo_PlayerInfoId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Skills_SkillsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Weapons_WeaponId",
                table: "CharacterInfos");

            migrationBuilder.AlterColumn<int>(
                name: "WeaponId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerInfoId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MonetaryWealthId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LastClassId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GrowthStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExpiriencePointsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentClassId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterDescriptionId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BaseStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArmorId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AbilitiesId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "FK_CharacterInfos_BaseStats_BaseStatsId",
                table: "CharacterInfos",
                column: "BaseStatsId",
                principalTable: "BaseStats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CharacterDescriptions_CharacterDescriptionId",
                table: "CharacterInfos",
                column: "CharacterDescriptionId",
                principalTable: "CharacterDescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                table: "CharacterInfos",
                column: "CurrentClassId",
                principalTable: "CurrentClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos",
                column: "CurrentStatsId",
                principalTable: "CurrentStats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Equipments_EquipmentId",
                table: "CharacterInfos",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_ExpiriencePoints_ExpiriencePointsId",
                table: "CharacterInfos",
                column: "ExpiriencePointsId",
                principalTable: "ExpiriencePoints",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_GrowthStats_GrowthStatsId",
                table: "CharacterInfos",
                column: "GrowthStatsId",
                principalTable: "GrowthStats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_LastClass_LastClassId",
                table: "CharacterInfos",
                column: "LastClassId",
                principalTable: "LastClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_MonetaryWealth_MonetaryWealthId",
                table: "CharacterInfos",
                column: "MonetaryWealthId",
                principalTable: "MonetaryWealth",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_PlayerInfo_PlayerInfoId",
                table: "CharacterInfos",
                column: "PlayerInfoId",
                principalTable: "PlayerInfo",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Abilities_AbilitiesId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Armors_ArmorId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_BaseStats_BaseStatsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CharacterDescriptions_CharacterDescriptionId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Equipments_EquipmentId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_ExpiriencePoints_ExpiriencePointsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_GrowthStats_GrowthStatsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_LastClass_LastClassId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_MonetaryWealth_MonetaryWealthId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_PlayerInfo_PlayerInfoId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Skills_SkillsId",
                table: "CharacterInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Weapons_WeaponId",
                table: "CharacterInfos");

            migrationBuilder.AlterColumn<int>(
                name: "WeaponId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerInfoId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MonetaryWealthId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LastClassId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GrowthStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExpiriencePointsId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentClassId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterDescriptionId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BaseStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArmorId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AbilitiesId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Abilities_AbilitiesId",
                table: "CharacterInfos",
                column: "AbilitiesId",
                principalTable: "Abilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Armors_ArmorId",
                table: "CharacterInfos",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_BaseStats_BaseStatsId",
                table: "CharacterInfos",
                column: "BaseStatsId",
                principalTable: "BaseStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CharacterDescriptions_CharacterDescriptionId",
                table: "CharacterInfos",
                column: "CharacterDescriptionId",
                principalTable: "CharacterDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                table: "CharacterInfos",
                column: "CurrentClassId",
                principalTable: "CurrentClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos",
                column: "CurrentStatsId",
                principalTable: "CurrentStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Equipments_EquipmentId",
                table: "CharacterInfos",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_ExpiriencePoints_ExpiriencePointsId",
                table: "CharacterInfos",
                column: "ExpiriencePointsId",
                principalTable: "ExpiriencePoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_GrowthStats_GrowthStatsId",
                table: "CharacterInfos",
                column: "GrowthStatsId",
                principalTable: "GrowthStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_LastClass_LastClassId",
                table: "CharacterInfos",
                column: "LastClassId",
                principalTable: "LastClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_MonetaryWealth_MonetaryWealthId",
                table: "CharacterInfos",
                column: "MonetaryWealthId",
                principalTable: "MonetaryWealth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_PlayerInfo_PlayerInfoId",
                table: "CharacterInfos",
                column: "PlayerInfoId",
                principalTable: "PlayerInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Skills_SkillsId",
                table: "CharacterInfos",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Weapons_WeaponId",
                table: "CharacterInfos",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
