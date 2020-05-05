using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBlazorEF.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "92c475ca-6168-465f-b022-b2278601705f", "Jane", "Smith", "Medicine" },
                    { "453e390c-16af-4b84-a0fd-e4140b072442", "John", "Fisher", "Engineering" },
                    { "d711000e-9925-4234-8387-db5b50e35098", "Pamela", "Baker", "Food Science" },
                    { "224f1421-85b9-4e00-a4de-8adfa19adf21", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
