using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class statsunified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDescriptions_BaseStats_BaseStatsId",
                table: "CharacterDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDescriptions_CurrentStats_CurrentStatsId",
                table: "CharacterDescriptions");

            migrationBuilder.DropTable(
                name: "BaseStats");

            migrationBuilder.DropTable(
                name: "CurrentStats");

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WW = table.Column<int>(type: "int", nullable: false),
                    US = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    SW = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false),
                    Zyw = table.Column<int>(type: "int", nullable: false),
                    S = table.Column<int>(type: "int", nullable: false),
                    Wt = table.Column<int>(type: "int", nullable: false),
                    Sz = table.Column<int>(type: "int", nullable: false),
                    Mag = table.Column<int>(type: "int", nullable: false),
                    PO = table.Column<int>(type: "int", nullable: false),
                    PP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDescriptions_Stats_BaseStatsId",
                table: "CharacterDescriptions",
                column: "BaseStatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDescriptions_Stats_CurrentStatsId",
                table: "CharacterDescriptions",
                column: "CurrentStatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDescriptions_Stats_BaseStatsId",
                table: "CharacterDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDescriptions_Stats_CurrentStatsId",
                table: "CharacterDescriptions");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.CreateTable(
                name: "BaseStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Mag = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    PO = table.Column<int>(type: "int", nullable: false),
                    PP = table.Column<int>(type: "int", nullable: false),
                    S = table.Column<int>(type: "int", nullable: false),
                    SW = table.Column<int>(type: "int", nullable: false),
                    Sz = table.Column<int>(type: "int", nullable: false),
                    US = table.Column<int>(type: "int", nullable: false),
                    WW = table.Column<int>(type: "int", nullable: false),
                    Wt = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Zyw = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Mag = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    PO = table.Column<int>(type: "int", nullable: false),
                    PP = table.Column<int>(type: "int", nullable: false),
                    S = table.Column<int>(type: "int", nullable: false),
                    SW = table.Column<int>(type: "int", nullable: false),
                    Sz = table.Column<int>(type: "int", nullable: false),
                    US = table.Column<int>(type: "int", nullable: false),
                    WW = table.Column<int>(type: "int", nullable: false),
                    Wt = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Zyw = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentStats", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDescriptions_BaseStats_BaseStatsId",
                table: "CharacterDescriptions",
                column: "BaseStatsId",
                principalTable: "BaseStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDescriptions_CurrentStats_CurrentStatsId",
                table: "CharacterDescriptions",
                column: "CurrentStatsId",
                principalTable: "CurrentStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
