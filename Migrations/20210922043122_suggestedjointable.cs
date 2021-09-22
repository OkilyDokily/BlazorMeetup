using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class suggestedjointable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuggestedDateAttendeeEvents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AttendeeEventId = table.Column<string>(type: "TEXT", nullable: true),
                    SuggestedDateId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedDateAttendeeEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuggestedDateAttendeeEvents_AttendeeEvents_AttendeeEventId",
                        column: x => x.AttendeeEventId,
                        principalTable: "AttendeeEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuggestedDateAttendeeEvents_SuggestedDates_SuggestedDateId",
                        column: x => x.SuggestedDateId,
                        principalTable: "SuggestedDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuggestedDateAttendeeEvents_AttendeeEventId",
                table: "SuggestedDateAttendeeEvents",
                column: "AttendeeEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SuggestedDateAttendeeEvents_SuggestedDateId",
                table: "SuggestedDateAttendeeEvents",
                column: "SuggestedDateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuggestedDateAttendeeEvents");
        }
    }
}
