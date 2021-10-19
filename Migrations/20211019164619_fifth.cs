using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_AttendeeId",
                table: "Events");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_AttendeeId",
                table: "Events");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AttendeeId",
                table: "Events",
                column: "AttendeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
