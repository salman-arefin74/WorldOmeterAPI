using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldOmeterAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countryViews",
                columns: table => new
                {
                    CvID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    totalCases = table.Column<int>(nullable: false),
                    newCases = table.Column<int>(nullable: false),
                    totalDeaths = table.Column<int>(nullable: false),
                    newDeaths = table.Column<int>(nullable: false),
                    totalRecovered = table.Column<int>(nullable: false),
                    activeCases = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countryViews", x => x.CvID);
                });

            migrationBuilder.CreateTable(
                name: "summaryCases",
                columns: table => new
                {
                    ScID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activeInfected = table.Column<int>(nullable: false),
                    activeMild = table.Column<int>(nullable: false),
                    activeSerious = table.Column<int>(nullable: false),
                    outcomeClosed = table.Column<int>(nullable: false),
                    recovered = table.Column<int>(nullable: false),
                    deaths = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_summaryCases", x => x.ScID);
                });

            migrationBuilder.CreateTable(
                name: "summaryTotals",
                columns: table => new
                {
                    StID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCases = table.Column<int>(nullable: false),
                    DeathCases = table.Column<int>(nullable: false),
                    RecoveredCases = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_summaryTotals", x => x.StID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "countryViews");

            migrationBuilder.DropTable(
                name: "summaryCases");

            migrationBuilder.DropTable(
                name: "summaryTotals");
        }
    }
}
