using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniProject.Migrations
{
    public partial class MiniProjectModelsGoalContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "GoalId", "GoalName" },
                values: new object[] { 1L, "Find Product" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "GoalId", "GoalName" },
                values: new object[] { 2L, "Select Product" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "GoalId", "GoalName" },
                values: new object[] { 3L, "Buy Product" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3L);
        }
    }
}
