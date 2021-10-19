using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds");

            migrationBuilder.AddForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds");

            migrationBuilder.AddForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
