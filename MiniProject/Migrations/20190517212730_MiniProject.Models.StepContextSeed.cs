using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniProject.Migrations
{
    public partial class MiniProjectModelsStepContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    StepId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StepName = table.Column<string>(nullable: true),
                    GoalId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.StepId);
                    table.ForeignKey(
                        name: "FK_Steps_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "StepId", "GoalId", "StepName" },
                values: new object[,]
                {
                    { 1L, 1L, "visit website" },
                    { 2L, 1L, "search product" },
                    { 3L, 1L, "order search results" },
                    { 4L, 2L, "order product detail" },
                    { 5L, 2L, "compare product" },
                    { 6L, 3L, "sign up" },
                    { 7L, 3L, "add to basket" },
                    { 8L, 3L, "place order" },
                    { 9L, 3L, "make payment" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Steps_GoalId",
                table: "Steps",
                column: "GoalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steps");
        }
    }
}
