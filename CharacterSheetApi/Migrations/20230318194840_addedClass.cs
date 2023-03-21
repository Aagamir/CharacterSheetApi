using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class addedClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_ClassId",
                table: "CharacterInfos",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_Classes_ClassId",
                table: "CharacterInfos",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_Classes_ClassId",
                table: "CharacterInfos");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_ClassId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "CharacterInfos");
        }
    }
}
