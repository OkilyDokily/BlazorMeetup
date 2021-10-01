using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class teamagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventId",
                table: "TeamAttendees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamAttendees_AttendeeId",
                table: "TeamAttendees",
                column: "AttendeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees");

            migrationBuilder.DropIndex(
                name: "IX_TeamAttendees_AttendeeId",
                table: "TeamAttendees");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "TeamAttendees");
        }
    }
}
