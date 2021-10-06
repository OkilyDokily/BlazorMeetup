using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class again2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AvatarSettingsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AvatarSettingsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AvatarSettingsId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "AvatarSettings",
                newName: "AvatarUrl");

            migrationBuilder.AddColumn<string>(
                name: "AttendeeId",
                table: "AvatarSettings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AvatarSettings_AttendeeId",
                table: "AvatarSettings",
                column: "AttendeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.DropIndex(
                name: "IX_AvatarSettings_AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.RenameColumn(
                name: "AvatarUrl",
                table: "AvatarSettings",
                newName: "FileName");

            migrationBuilder.AddColumn<string>(
                name: "AvatarSettingsId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AvatarSettingsId",
                table: "AspNetUsers",
                column: "AvatarSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AvatarSettingsId",
                table: "AspNetUsers",
                column: "AvatarSettingsId",
                principalTable: "AvatarSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
