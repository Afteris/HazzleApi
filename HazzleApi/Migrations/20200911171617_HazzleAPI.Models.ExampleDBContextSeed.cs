using Microsoft.EntityFrameworkCore.Migrations;

namespace HazzleApi.Migrations
{
    public partial class HazzleAPIModelsExampleDBContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExampleModels",
                columns: new[] { "Id", "Age", "JobTitle", "Name", "Username" },
                values: new object[] { 1, 33, "Master of None", "Jamppa Javonen", "MoN" });

            migrationBuilder.InsertData(
                table: "ExampleModels",
                columns: new[] { "Id", "Age", "JobTitle", "Name", "Username" },
                values: new object[] { 2, 33, "Master of None", "Jamppa Javonen", "MoN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExampleModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExampleModels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
