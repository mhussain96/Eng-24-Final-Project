using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialisations",
                columns: table => new
                {
                    SpecID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpecName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisations", x => x.SpecID);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleID);
                });

            migrationBuilder.CreateTable(
                name: "Cohorts",
                columns: table => new
                {
                    CohortID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CohortName = table.Column<string>(nullable: true),
                    CohortNumber = table.Column<int>(nullable: false),
                    SpecialisationSpecID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cohorts", x => x.CohortID);
                    table.ForeignKey(
                        name: "FK_Cohorts_Specialisations_SpecialisationSpecID",
                        column: x => x.SpecialisationSpecID,
                        principalTable: "Specialisations",
                        principalColumn: "SpecID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spartans",
                columns: table => new
                {
                    SpartanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    CohortID = table.Column<int>(nullable: false),
                    TitleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spartans", x => x.SpartanID);
                    table.ForeignKey(
                        name: "FK_Spartans_Cohorts_CohortID",
                        column: x => x.CohortID,
                        principalTable: "Cohorts",
                        principalColumn: "CohortID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spartans_Titles_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Titles",
                        principalColumn: "TitleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cohorts_SpecialisationSpecID",
                table: "Cohorts",
                column: "SpecialisationSpecID");

            migrationBuilder.CreateIndex(
                name: "IX_Spartans_CohortID",
                table: "Spartans",
                column: "CohortID");

            migrationBuilder.CreateIndex(
                name: "IX_Spartans_TitleID",
                table: "Spartans",
                column: "TitleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spartans");

            migrationBuilder.DropTable(
                name: "Cohorts");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Specialisations");
        }
    }
}
