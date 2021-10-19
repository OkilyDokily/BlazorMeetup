using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AttendeeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AttendeeId",
                table: "AspNetUsers",
                column: "AttendeeId",
                principalTable: "AvatarSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AttendeeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AttendeeId",
                table: "AspNetUsers",
                column: "AttendeeId",
                principalTable: "AvatarSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
