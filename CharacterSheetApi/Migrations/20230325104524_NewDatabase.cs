using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSheetApi.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmorType",
                columns: table => new
                {
                    ArmorTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorType", x => x.ArmorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BaseStats",
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
                    table.PrimaryKey("PK_BaseStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyLocations",
                columns: table => new
                {
                    BodyLocationsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyLocations", x => x.BodyLocationsId);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "CurrentStats",
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
                    table.PrimaryKey("PK_CurrentStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpiriencePoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentPoints = table.Column<int>(type: "int", nullable: false),
                    OverallPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpiriencePoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EyeColor",
                columns: table => new
                {
                    EyeColorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EyeColor", x => x.EyeColorId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "GrowthStats",
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
                    table.PrimaryKey("PK_GrowthStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HairColor",
                columns: table => new
                {
                    HairColorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairColor", x => x.HairColorId);
                });

            migrationBuilder.CreateTable(
                name: "LastClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonetaryWealth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoldCrowns = table.Column<int>(type: "int", nullable: false),
                    SilverShilling = table.Column<int>(type: "int", nullable: false),
                    CopperPences = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonetaryWealth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameMasterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampaignName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RpgSystem",
                columns: table => new
                {
                    RpgSystemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RpgSystem", x => x.RpgSystemId);
                });

            migrationBuilder.CreateTable(
                name: "SkillLevel",
                columns: table => new
                {
                    SkillLevelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillLevel", x => x.SkillLevelId);
                });

            migrationBuilder.CreateTable(
                name: "StarSign",
                columns: table => new
                {
                    StarSignId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarSign", x => x.StarSignId);
                });

            migrationBuilder.CreateTable(
                name: "WeaponCategory",
                columns: table => new
                {
                    WeaponCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponCategory", x => x.WeaponCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "WeaponsCharacteristics",
                columns: table => new
                {
                    WeaponCharacteristicsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponsCharacteristics", x => x.WeaponCharacteristicsId);
                });

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmorTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArmorPoints = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Armors_ArmorType_ArmorTypeId",
                        column: x => x.ArmorTypeId,
                        principalTable: "ArmorType",
                        principalColumn: "ArmorTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_SkillLevel_SkillLevelId",
                        column: x => x.SkillLevelId,
                        principalTable: "SkillLevel",
                        principalColumn: "SkillLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    EyeColorId = table.Column<int>(type: "int", nullable: false),
                    HairColorId = table.Column<int>(type: "int", nullable: false),
                    StarSignId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Siblings = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacteriticSigns = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterDescriptions_EyeColor_EyeColorId",
                        column: x => x.EyeColorId,
                        principalTable: "EyeColor",
                        principalColumn: "EyeColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDescriptions_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDescriptions_HairColor_HairColorId",
                        column: x => x.HairColorId,
                        principalTable: "HairColor",
                        principalColumn: "HairColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDescriptions_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDescriptions_StarSign_StarSignId",
                        column: x => x.StarSignId,
                        principalTable: "StarSign",
                        principalColumn: "StarSignId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    WeaponCategoryId = table.Column<int>(type: "int", nullable: false),
                    WeaponStrength = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    ReloadTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponCategory_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalTable: "WeaponCategory",
                        principalColumn: "WeaponCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "CharacterInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerInfoId = table.Column<int>(type: "int", nullable: false),
                    ExpiriencePointsId = table.Column<int>(type: "int", nullable: false),
                    CharacterDescriptionId = table.Column<int>(type: "int", nullable: false),
                    CurrentClassId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    LastClassId = table.Column<int>(type: "int", nullable: true),
                    BaseStatsId = table.Column<int>(type: "int", nullable: false),
                    GrowthStatsId = table.Column<int>(type: "int", nullable: true),
                    CurrentStatsId = table.Column<int>(type: "int", nullable: true),
                    MonetaryWealthId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_BaseStats_BaseStatsId",
                        column: x => x.BaseStatsId,
                        principalTable: "BaseStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_CharacterDescriptions_CharacterDescriptionId",
                        column: x => x.CharacterDescriptionId,
                        principalTable: "CharacterDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_CurrentClass_CurrentClassId",
                        column: x => x.CurrentClassId,
                        principalTable: "CurrentClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_CurrentStats_CurrentStatsId",
                        column: x => x.CurrentStatsId,
                        principalTable: "CurrentStats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharacterInfos_ExpiriencePoints_ExpiriencePointsId",
                        column: x => x.ExpiriencePointsId,
                        principalTable: "ExpiriencePoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_GrowthStats_GrowthStatsId",
                        column: x => x.GrowthStatsId,
                        principalTable: "GrowthStats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharacterInfos_LastClass_LastClassId",
                        column: x => x.LastClassId,
                        principalTable: "LastClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharacterInfos_MonetaryWealth_MonetaryWealthId",
                        column: x => x.MonetaryWealthId,
                        principalTable: "MonetaryWealth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInfos_PlayerInfo_PlayerInfoId",
                        column: x => x.PlayerInfoId,
                        principalTable: "PlayerInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_WeaponWeaponCharacteristics_WeaponsCharacteristics_WeaponCharacteristicsId",
                        column: x => x.WeaponCharacteristicsId,
                        principalTable: "WeaponsCharacteristics",
                        principalColumn: "WeaponCharacteristicsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponWeaponCharacteristics_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RpgSystemId = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterInfoId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterSheets_CharacterInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharacterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSheets_RpgSystem_RpgSystemId",
                        column: x => x.RpgSystemId,
                        principalTable: "RpgSystem",
                        principalColumn: "RpgSystemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSheets_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ArmorType",
                columns: new[] { "ArmorTypeId", "Name" },
                values: new object[,]
                {
                    { 0, "LeahterHelmet" },
                    { 1, "Caftan" },
                    { 2, "LeatherJacket" },
                    { 3, "Leggings" },
                    { 4, "LeatherSuit" },
                    { 5, "ChainHelmet" },
                    { 6, "ChainCaftan" },
                    { 7, "ChainJacket" },
                    { 8, "ChainMail" },
                    { 9, "ChainMailWithSleeves" },
                    { 10, "ChainLeggings" },
                    { 11, "ChainSuit" },
                    { 12, "PlateHelmet" },
                    { 13, "ShoulderPads" },
                    { 14, "PlateLeggings" },
                    { 15, "ChestPlate" },
                    { 16, "PlateArmor" }
                });

            migrationBuilder.InsertData(
                table: "BodyLocations",
                columns: new[] { "BodyLocationsId", "Name" },
                values: new object[,]
                {
                    { 0, "Head" },
                    { 1, "LeftArm" },
                    { 2, "RightArm" },
                    { 3, "LeftLeg" },
                    { 4, "RightLeg" },
                    { 5, "Torso" },
                    { 6, "WholeBody" }
                });

            migrationBuilder.InsertData(
                table: "EyeColor",
                columns: new[] { "EyeColorId", "Name" },
                values: new object[,]
                {
                    { 0, "Grey" },
                    { 1, "DarkBlue" },
                    { 2, "Blue" },
                    { 3, "Green" },
                    { 4, "Beer" },
                    { 5, "LightBrown" },
                    { 6, "Brown" },
                    { 7, "DarkBrown" },
                    { 8, "Purple" },
                    { 9, "Black" },
                    { 10, "GreyBlue" },
                    { 11, "Walnut" },
                    { 12, "Chestnut" },
                    { 13, "Silver" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "Name" },
                values: new object[,]
                {
                    { 0, "Male" },
                    { 1, "Female" }
                });

            migrationBuilder.InsertData(
                table: "HairColor",
                columns: new[] { "HairColorId", "Name" },
                values: new object[,]
                {
                    { 0, "Ash" },
                    { 1, "DarkBlonde" },
                    { 2, "Blonde" },
                    { 3, "Ginger" },
                    { 4, "DarkGinger" },
                    { 5, "LightBrown" },
                    { 6, "Brown" },
                    { 7, "DarkBrown" },
                    { 8, "Black" },
                    { 9, "Silver" },
                    { 10, "White" },
                    { 11, "LightBlonde" },
                    { 12, "Copper" },
                    { 13, "Chestnut" },
                    { 14, "Red" },
                    { 15, "RavenBlack" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "RaceId", "Name" },
                values: new object[,]
                {
                    { 0, "Human" },
                    { 1, "Elf" },
                    { 2, "Dwarf" },
                    { 3, "Hafling" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { 0, "Admin" },
                    { 1, "User" }
                });

            migrationBuilder.InsertData(
                table: "RpgSystem",
                columns: new[] { "RpgSystemId", "Name" },
                values: new object[,]
                {
                    { 0, "WRFRPG_1ED" },
                    { 1, "WRFRPG_2ED" },
                    { 2, "WRFRPG_4ED" },
                    { 3, "Cthulhu" },
                    { 4, "TalesFromTheLoop" }
                });

            migrationBuilder.InsertData(
                table: "SkillLevel",
                columns: new[] { "SkillLevelId", "Name" },
                values: new object[,]
                {
                    { 0, "Bought" },
                    { 1, "Plus10" },
                    { 2, "Plus20" }
                });

            migrationBuilder.InsertData(
                table: "StarSign",
                columns: new[] { "StarSignId", "Name" },
                values: new object[,]
                {
                    { 0, "Drummer" },
                    { 1, "Bagpipe" },
                    { 2, "TwoBulls" },
                    { 3, "FoolMummit" },
                    { 4, "CharmStar" },
                    { 5, "EveningtideStar" },
                    { 6, "RhyiasCauldron" },
                    { 7, "Lancet" },
                    { 8, "SageMammit" },
                    { 9, "GurngisBelt" },
                    { 10, "CrashedCart" },
                    { 11, "DragonDragomas" },
                    { 12, "limnersRope" },
                    { 13, "Dancer" },
                    { 14, "FatGoat" },
                    { 15, "VobisTheEthereal" },
                    { 16, "GreatCross" },
                    { 17, "OxGnuthus" },
                    { 18, "HermitWyzmund" },
                    { 19, "GoldenCock" }
                });

            migrationBuilder.InsertData(
                table: "WeaponCategory",
                columns: new[] { "WeaponCategoryId", "Name" },
                values: new object[,]
                {
                    { 0, "Normal" },
                    { 1, "TwoHanded" },
                    { 2, "Cavalry" },
                    { 3, "Kurbash" },
                    { 4, "Parrying" },
                    { 5, "Immobilizing" },
                    { 6, "LongBow" },
                    { 7, "FireArm" },
                    { 8, "Crossbow" },
                    { 9, "Mechanical" },
                    { 10, "Throwable" },
                    { 11, "Slingshot" }
                });

            migrationBuilder.InsertData(
                table: "WeaponsCharacteristics",
                columns: new[] { "WeaponCharacteristicsId", "Name" },
                values: new object[,]
                {
                    { 0, "Heavy" },
                    { 1, "Devastating" },
                    { 2, "Experimental" },
                    { 3, "Splinter" },
                    { 4, "Deafening" },
                    { 5, "Parrying" },
                    { 6, "Slow" },
                    { 7, "Precise" },
                    { 8, "Piercing" },
                    { 9, "Special" },
                    { 10, "Fast" },
                    { 11, "Immobilizing" },
                    { 12, "Balanced" },
                    { 13, "Unreliable" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityCharacterInfo_CharacterInfoId",
                table: "AbilityCharacterInfo",
                column: "CharacterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorBodyLocations_BodyLocationsId",
                table: "ArmorBodyLocations",
                column: "BodyLocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorCharacterInfo_CharacterInfoId",
                table: "ArmorCharacterInfo",
                column: "CharacterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_ArmorTypeId",
                table: "Armors",
                column: "ArmorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDescriptions_EyeColorId",
                table: "CharacterDescriptions",
                column: "EyeColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDescriptions_GenderId",
                table: "CharacterDescriptions",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDescriptions_HairColorId",
                table: "CharacterDescriptions",
                column: "HairColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDescriptions_RaceId",
                table: "CharacterDescriptions",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDescriptions_StarSignId",
                table: "CharacterDescriptions",
                column: "StarSignId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfoEquipment_EquipmentId",
                table: "CharacterInfoEquipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_BaseStatsId",
                table: "CharacterInfos",
                column: "BaseStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_CharacterDescriptionId",
                table: "CharacterInfos",
                column: "CharacterDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_ClassId",
                table: "CharacterInfos",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_CurrentClassId",
                table: "CharacterInfos",
                column: "CurrentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_CurrentStatsId",
                table: "CharacterInfos",
                column: "CurrentStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_ExpiriencePointsId",
                table: "CharacterInfos",
                column: "ExpiriencePointsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_GrowthStatsId",
                table: "CharacterInfos",
                column: "GrowthStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_LastClassId",
                table: "CharacterInfos",
                column: "LastClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_MonetaryWealthId",
                table: "CharacterInfos",
                column: "MonetaryWealthId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfos_PlayerInfoId",
                table: "CharacterInfos",
                column: "PlayerInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfoSkill_SkillsId",
                table: "CharacterInfoSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInfoWeapon_WeaponsId",
                table: "CharacterInfoWeapon",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_CharacterInfoId",
                table: "CharacterSheets",
                column: "CharacterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_RpgSystemId",
                table: "CharacterSheets",
                column: "RpgSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_UsersId",
                table: "CharacterSheets",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillLevelId",
                table: "Skills",
                column: "SkillLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponCategoryId",
                table: "Weapons",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponWeaponCharacteristics_WeaponsId",
                table: "WeaponWeaponCharacteristics",
                column: "WeaponsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityCharacterInfo");

            migrationBuilder.DropTable(
                name: "ArmorBodyLocations");

            migrationBuilder.DropTable(
                name: "ArmorCharacterInfo");

            migrationBuilder.DropTable(
                name: "CharacterInfoEquipment");

            migrationBuilder.DropTable(
                name: "CharacterInfoSkill");

            migrationBuilder.DropTable(
                name: "CharacterInfoWeapon");

            migrationBuilder.DropTable(
                name: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "WeaponWeaponCharacteristics");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "BodyLocations");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "CharacterInfos");

            migrationBuilder.DropTable(
                name: "RpgSystem");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WeaponsCharacteristics");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "ArmorType");

            migrationBuilder.DropTable(
                name: "SkillLevel");

            migrationBuilder.DropTable(
                name: "BaseStats");

            migrationBuilder.DropTable(
                name: "CharacterDescriptions");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "CurrentClass");

            migrationBuilder.DropTable(
                name: "CurrentStats");

            migrationBuilder.DropTable(
                name: "ExpiriencePoints");

            migrationBuilder.DropTable(
                name: "GrowthStats");

            migrationBuilder.DropTable(
                name: "LastClass");

            migrationBuilder.DropTable(
                name: "MonetaryWealth");

            migrationBuilder.DropTable(
                name: "PlayerInfo");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "WeaponCategory");

            migrationBuilder.DropTable(
                name: "EyeColor");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "HairColor");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "StarSign");
        }
    }
}
