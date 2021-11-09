using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttendeeId",
                table: "Servers",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_AttendeeId",
                table: "Servers",
                column: "AttendeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Servers_AttendeeId",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Servers");
        }
    }
}
