using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Attendees_IdentityUserId",
                table: "Attendees",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_AspNetUsers_IdentityUserId",
                table: "Attendees",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_AspNetUsers_IdentityUserId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_IdentityUserId",
                table: "Attendees");
        }
    }
}
