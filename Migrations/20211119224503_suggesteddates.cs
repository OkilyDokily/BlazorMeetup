using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class suggesteddates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees");

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees",
                column: "SuggestedDateId",
                principalTable: "SuggestedDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees");

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees",
                column: "SuggestedDateId",
                principalTable: "SuggestedDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
