using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class yetagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers");

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers");

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
