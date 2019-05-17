using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniProject.Migrations
{
    public partial class MiniProjectModelsStoryContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    StoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryName = table.Column<string>(nullable: true),
                    ReleaseId = table.Column<int>(nullable: false),
                    StepId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.StoryId);
                    table.ForeignKey(
                        name: "FK_Stories_Steps_StepId",
                        column: x => x.StepId,
                        principalTable: "Steps",
                        principalColumn: "StepId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryId", "ReleaseId", "StepId", "StoryName" },
                values: new object[,]
                {
                    { 1L, 1, 1L, "Static website from template" },
                    { 2L, 1, 2L, "open standard search panel" },
                    { 3L, 1, 2L, "search by name" },
                    { 4L, 2, 2L, "open detailed search panel" },
                    { 5L, 2, 2L, "search by category" },
                    { 6L, 2, 2L, "search by brand" },
                    { 7L, 2, 3L, "order by price" },
                    { 8L, 1, 4L, "standard product data sheet" },
                    { 9L, 1, 6L, "sign up with regular account" },
                    { 10L, 1, 7L, "add to basket" },
                    { 11L, 1, 8L, "add shipping address" },
                    { 12L, 1, 8L, "choose shipping method" },
                    { 13L, 1, 9L, "pay by bank transaction" },
                    { 14L, 2, 9L, "pay by bank card" },
                    { 15L, 2, 9L, "pay by PayPal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_StepId",
                table: "Stories",
                column: "StepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
