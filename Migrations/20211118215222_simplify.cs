using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class simplify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Servers_ServerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CanAttendProposedDate",
                table: "AttendeeEvents");

            migrationBuilder.AlterColumn<string>(
                name: "ServerId",
                table: "Events",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Servers_ServerId",
                table: "Events",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Servers_ServerId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "ServerId",
                table: "Events",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "CanAttendProposedDate",
                table: "AttendeeEvents",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Servers_ServerId",
                table: "Events",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
