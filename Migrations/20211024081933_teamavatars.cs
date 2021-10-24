using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class teamavatars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarSettingsId",
                table: "Teams",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_AvatarSettingsId",
                table: "Teams",
                column: "AvatarSettingsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_AvatarSettings_AvatarSettingsId",
                table: "Teams",
                column: "AvatarSettingsId",
                principalTable: "AvatarSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AvatarSettings_AvatarSettingsId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_AvatarSettingsId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "AvatarSettingsId",
                table: "Teams");
        }
    }
}
