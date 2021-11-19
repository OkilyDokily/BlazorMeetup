using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class morestuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RestrictDateId",
                table: "SuggestedDates",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SuggestedDates_RestrictDateId",
                table: "SuggestedDates",
                column: "RestrictDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDates_RestrictDates_RestrictDateId",
                table: "SuggestedDates",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDates_RestrictDates_RestrictDateId",
                table: "SuggestedDates");

            migrationBuilder.DropIndex(
                name: "IX_SuggestedDates_RestrictDateId",
                table: "SuggestedDates");

            migrationBuilder.DropColumn(
                name: "RestrictDateId",
                table: "SuggestedDates");
        }
    }
}
