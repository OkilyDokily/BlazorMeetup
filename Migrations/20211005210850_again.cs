using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
