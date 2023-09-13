using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.data.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "area",
                columns: table => new
                {
                    id_area = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descriptionarea = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_area", x => x.id_area);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "category_contact",
                columns: table => new
                {
                    id_categoryContact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_contact", x => x.id_categoryContact);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoryIncidence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryIncidence", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    id_country = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.id_country);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_gender = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "priority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priority", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id_rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_rol = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id_rol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    id_state = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.id_state);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_team = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "type_contact",
                columns: table => new
                {
                    id_contacttype = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_contact = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_contact", x => x.id_contacttype);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "type_document",
                columns: table => new
                {
                    id_documenttype = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    abbreviation = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_document", x => x.id_documenttype);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "type_person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_person", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameUser = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "place",
                columns: table => new
                {
                    id_place = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_place = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    capacity = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdArea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_place", x => x.id_place);
                    table.ForeignKey(
                        name: "FK_place_area_IdArea",
                        column: x => x.IdArea,
                        principalTable: "area",
                        principalColumn: "id_area",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "region",
                columns: table => new
                {
                    id_region = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_region = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCountry = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_region", x => x.id_region);
                    table.ForeignKey(
                        name: "FK_region_country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "country",
                        principalColumn: "id_country",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRol",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRol", x => new { x.UserId, x.RolId });
                    table.ForeignKey(
                        name: "FK_UserRol_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "id_rol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRol_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    id_city = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRegion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.id_city);
                    table.ForeignKey(
                        name: "FK_city_region_IdRegion",
                        column: x => x.IdRegion,
                        principalTable: "region",
                        principalColumn: "id_region",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id_person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDocumentType = table.Column<int>(type: "int", nullable: false),
                    TypeDocumentId = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastname = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdGender = table.Column<int>(type: "int", nullable: false),
                    IdCity = table.Column<int>(type: "int", nullable: false),
                    IdTypePer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id_person);
                    table.ForeignKey(
                        name: "FK_person_city_IdCity",
                        column: x => x.IdCity,
                        principalTable: "city",
                        principalColumn: "id_city",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_person_gender_IdGender",
                        column: x => x.IdGender,
                        principalTable: "gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_person_type_document_TypeDocumentId",
                        column: x => x.TypeDocumentId,
                        principalTable: "type_document",
                        principalColumn: "id_documenttype");
                    table.ForeignKey(
                        name: "FK_person_type_person_IdTypePer",
                        column: x => x.IdTypePer,
                        principalTable: "type_person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    id_address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_neigborhood = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_way = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quadran_prefix = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    number_way = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_venereableWay = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    number_plate = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdCity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id_address);
                    table.ForeignKey(
                        name: "FK_address_city_IdCity",
                        column: x => x.IdCity,
                        principalTable: "city",
                        principalColumn: "id_city",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "person",
                        principalColumn: "id_person",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    id_contact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    type_contact = table.Column<int>(type: "int", nullable: false),
                    category_contact = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.id_contact);
                    table.ForeignKey(
                        name: "FK_contact_category_contact_category_contact",
                        column: x => x.category_contact,
                        principalTable: "category_contact",
                        principalColumn: "id_categoryContact",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "person",
                        principalColumn: "id_person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_type_contact_type_contact",
                        column: x => x.type_contact,
                        principalTable: "type_contact",
                        principalColumn: "id_contacttype",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "incidence",
                columns: table => new
                {
                    id_incidence = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_user = table.Column<int>(type: "int", nullable: false),
                    id_place = table.Column<int>(type: "int", nullable: false),
                    id_state = table.Column<int>(type: "int", nullable: false),
                    id_priority = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "Date", nullable: false),
                    id_categoryincidence = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidence", x => x.id_incidence);
                    table.ForeignKey(
                        name: "FK_incidence_CategoryIncidence_id_categoryincidence",
                        column: x => x.id_categoryincidence,
                        principalTable: "CategoryIncidence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_incidence_person_id_user",
                        column: x => x.id_user,
                        principalTable: "person",
                        principalColumn: "id_person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_incidence_place_id_place",
                        column: x => x.id_place,
                        principalTable: "place",
                        principalColumn: "id_place",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_incidence_priority_id_priority",
                        column: x => x.id_priority,
                        principalTable: "priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_incidence_state_id_state",
                        column: x => x.id_state,
                        principalTable: "state",
                        principalColumn: "id_state",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trainer_classroom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_trainer = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    id_classroom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainer_classroom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainer_classroom_person_id_trainer",
                        column: x => x.id_trainer,
                        principalTable: "person",
                        principalColumn: "id_person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainer_classroom_place_id_classroom",
                        column: x => x.id_classroom,
                        principalTable: "place",
                        principalColumn: "id_place",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tuition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdTeam = table.Column<int>(type: "int", nullable: false),
                    IdClassroom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tuition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tuition_person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "person",
                        principalColumn: "id_person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tuition_place_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "place",
                        principalColumn: "id_place",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tuition_team_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_address_IdCity",
                table: "address",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_address_IdPerson",
                table: "address",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_city_IdRegion",
                table: "city",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_contact_category_contact",
                table: "contact",
                column: "category_contact");

            migrationBuilder.CreateIndex(
                name: "IX_contact_IdPerson",
                table: "contact",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_contact_type_contact",
                table: "contact",
                column: "type_contact");

            migrationBuilder.CreateIndex(
                name: "IX_incidence_id_categoryincidence",
                table: "incidence",
                column: "id_categoryincidence");

            migrationBuilder.CreateIndex(
                name: "IX_incidence_id_place",
                table: "incidence",
                column: "id_place");

            migrationBuilder.CreateIndex(
                name: "IX_incidence_id_priority",
                table: "incidence",
                column: "id_priority");

            migrationBuilder.CreateIndex(
                name: "IX_incidence_id_state",
                table: "incidence",
                column: "id_state");

            migrationBuilder.CreateIndex(
                name: "IX_incidence_id_user",
                table: "incidence",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_person_IdCity",
                table: "person",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_person_IdGender",
                table: "person",
                column: "IdGender");

            migrationBuilder.CreateIndex(
                name: "IX_person_IdTypePer",
                table: "person",
                column: "IdTypePer");

            migrationBuilder.CreateIndex(
                name: "IX_person_TypeDocumentId",
                table: "person",
                column: "TypeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_place_IdArea",
                table: "place",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_region_IdCountry",
                table: "region",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_trainer_classroom_id_classroom",
                table: "trainer_classroom",
                column: "id_classroom");

            migrationBuilder.CreateIndex(
                name: "IX_trainer_classroom_id_trainer",
                table: "trainer_classroom",
                column: "id_trainer");

            migrationBuilder.CreateIndex(
                name: "IX_tuition_IdPerson",
                table: "tuition",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_UserRol_RolId",
                table: "UserRol",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "incidence");

            migrationBuilder.DropTable(
                name: "trainer_classroom");

            migrationBuilder.DropTable(
                name: "tuition");

            migrationBuilder.DropTable(
                name: "UserRol");

            migrationBuilder.DropTable(
                name: "category_contact");

            migrationBuilder.DropTable(
                name: "type_contact");

            migrationBuilder.DropTable(
                name: "CategoryIncidence");

            migrationBuilder.DropTable(
                name: "priority");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "place");

            migrationBuilder.DropTable(
                name: "team");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "type_document");

            migrationBuilder.DropTable(
                name: "type_person");

            migrationBuilder.DropTable(
                name: "area");

            migrationBuilder.DropTable(
                name: "region");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
