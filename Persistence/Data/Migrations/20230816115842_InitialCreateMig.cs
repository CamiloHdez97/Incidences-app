using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    IdCountry = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameCountry = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.IdCountry);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    IdGender = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameGender = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.IdGender);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "lounges",
                columns: table => new
                {
                    IdLounge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameLounge = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lounges", x => x.IdLounge);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypePersons",
                columns: table => new
                {
                    IdTypePerson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescriptionTypePerson = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePersons", x => x.IdTypePerson);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    IdRegion = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameRegion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCountryFk = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryIdCountry = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.IdRegion);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryIdCountry",
                        column: x => x.CountryIdCountry,
                        principalTable: "Countries",
                        principalColumn: "IdCountry");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    IdCity = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameCity = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRegFk = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionIdRegion = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.IdCity);
                    table.ForeignKey(
                        name: "FK_Cities_Regions_RegionIdRegion",
                        column: x => x.RegionIdRegion,
                        principalTable: "Regions",
                        principalColumn: "IdRegion");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    IdPerson = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamePerson = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdGenderFk = table.Column<int>(type: "int", nullable: false),
                    GenderIdGender = table.Column<int>(type: "int", nullable: true),
                    IdCityFk = table.Column<int>(type: "int", nullable: false),
                    CityIdCity = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTypePerFk = table.Column<int>(type: "int", nullable: false),
                    TypePersonIdTypePerson = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Persons_Cities_CityIdCity",
                        column: x => x.CityIdCity,
                        principalTable: "Cities",
                        principalColumn: "IdCity");
                    table.ForeignKey(
                        name: "FK_Persons_Genders_GenderIdGender",
                        column: x => x.GenderIdGender,
                        principalTable: "Genders",
                        principalColumn: "IdGender");
                    table.ForeignKey(
                        name: "FK_Persons_TypePersons_TypePersonIdTypePerson",
                        column: x => x.TypePersonIdTypePerson,
                        principalTable: "TypePersons",
                        principalColumn: "IdTypePerson");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainerLounges",
                columns: table => new
                {
                    IdPerTrainerFk = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonIdPerson = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdLoungeFk = table.Column<int>(type: "int", nullable: false),
                    LoungeIdLounge = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerLounges", x => x.IdPerTrainerFk);
                    table.ForeignKey(
                        name: "FK_TrainerLounges_Persons_PersonIdPerson",
                        column: x => x.PersonIdPerson,
                        principalTable: "Persons",
                        principalColumn: "IdPerson");
                    table.ForeignKey(
                        name: "FK_TrainerLounges_lounges_LoungeIdLounge",
                        column: x => x.LoungeIdLounge,
                        principalTable: "lounges",
                        principalColumn: "IdLounge");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tuitions",
                columns: table => new
                {
                    IdTuition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPersonFk = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonIdPerson = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdLoungeFk = table.Column<int>(type: "int", nullable: false),
                    LoungeIdLounge = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuitions", x => x.IdTuition);
                    table.ForeignKey(
                        name: "FK_Tuitions_Persons_PersonIdPerson",
                        column: x => x.PersonIdPerson,
                        principalTable: "Persons",
                        principalColumn: "IdPerson");
                    table.ForeignKey(
                        name: "FK_Tuitions_lounges_LoungeIdLounge",
                        column: x => x.LoungeIdLounge,
                        principalTable: "lounges",
                        principalColumn: "IdLounge");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RegionIdRegion",
                table: "Cities",
                column: "RegionIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CityIdCity",
                table: "Persons",
                column: "CityIdCity");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GenderIdGender",
                table: "Persons",
                column: "GenderIdGender");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TypePersonIdTypePerson",
                table: "Persons",
                column: "TypePersonIdTypePerson");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryIdCountry",
                table: "Regions",
                column: "CountryIdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerLounges_LoungeIdLounge",
                table: "TrainerLounges",
                column: "LoungeIdLounge");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerLounges_PersonIdPerson",
                table: "TrainerLounges",
                column: "PersonIdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Tuitions_LoungeIdLounge",
                table: "Tuitions",
                column: "LoungeIdLounge");

            migrationBuilder.CreateIndex(
                name: "IX_Tuitions_PersonIdPerson",
                table: "Tuitions",
                column: "PersonIdPerson");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainerLounges");

            migrationBuilder.DropTable(
                name: "Tuitions");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "lounges");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "TypePersons");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
