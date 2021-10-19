using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttendeeId",
                table: "AspNetUsers",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AttendeeId",
                table: "AspNetUsers",
                column: "AttendeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AttendeeId",
                table: "AspNetUsers",
                column: "AttendeeId",
                principalTable: "AvatarSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AvatarSettings_AttendeeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AttendeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "AspNetUsers");
        }
    }
}
