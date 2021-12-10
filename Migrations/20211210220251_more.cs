using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class more : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
