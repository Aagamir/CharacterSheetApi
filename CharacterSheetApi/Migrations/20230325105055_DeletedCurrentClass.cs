using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class DeletedCurrentClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                table: "CharacterInfos");

            migrationBuilder.DropTable(
                name: "CurrentClass");

            migrationBuilder.DropIndex(
                name: "IX_CharacterInfos_CurrentClassId",
                table: "CharacterInfos");

            migrationBuilder.DropColumn(
                name: "CurrentClassId",
                table: "CharacterInfos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentClassId",
                table: "CharacterInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CurrentClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentClass", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_CurrentClassId",
                table: "CharacterInfos",
                column: "CurrentClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                table: "CharacterInfos",
                column: "CurrentClassId",
                principalTable: "CurrentClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
