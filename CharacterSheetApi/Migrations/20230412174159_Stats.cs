using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class Stats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos",
                column: "CurrentStatsId",
                principalTable: "CurrentStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentStatsId",
                table: "CharacterInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                table: "CharacterInfos",
                column: "CurrentStatsId",
                principalTable: "CurrentStats",
                principalColumn: "Id");
        }
    }
}
