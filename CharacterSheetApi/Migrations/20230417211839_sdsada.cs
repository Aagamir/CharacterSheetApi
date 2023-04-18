using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class sdsada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Users_UsersId",
                table: "CharacterSheets");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "CharacterSheets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Users_UsersId",
                table: "CharacterSheets",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Users_UsersId",
                table: "CharacterSheets");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "CharacterSheets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Users_UsersId",
                table: "CharacterSheets",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
