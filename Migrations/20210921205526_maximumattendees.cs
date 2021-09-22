using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class maximumattendees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CanAttendInitialDate",
                table: "AttendeeEvents",
                newName: "CanAttendProposedDate");

            migrationBuilder.AddColumn<int>(
                name: "MinimumAttendees",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumAttendees",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "CanAttendProposedDate",
                table: "AttendeeEvents",
                newName: "CanAttendInitialDate");
        }
    }
}
