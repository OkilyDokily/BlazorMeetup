using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvents_AspNetUsers_AttendeeId",
                table: "AttendeeEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvents_Events_EventId",
                table: "AttendeeEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_RestrictDates_Events_EventId",
                table: "RestrictDates");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDates_Events_EventId",
                table: "SuggestedDates");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_Teams_TeamId",
                table: "TeamAttendees");

            migrationBuilder.AlterColumn<string>(
                name: "EventId",
                table: "Teams",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_EventId",
                table: "Teams",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvents_AspNetUsers_AttendeeId",
                table: "AttendeeEvents",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvents_Events_EventId",
                table: "AttendeeEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestrictDates_Events_EventId",
                table: "RestrictDates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDates_Events_EventId",
                table: "SuggestedDates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAttendees_Teams_TeamId",
                table: "TeamAttendees",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvents_AspNetUsers_AttendeeId",
                table: "AttendeeEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvents_Events_EventId",
                table: "AttendeeEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_RestrictDates_Events_EventId",
                table: "RestrictDates");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDates_Events_EventId",
                table: "SuggestedDates");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_Teams_TeamId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_EventId",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "EventId",
                table: "Teams",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvents_AspNetUsers_AttendeeId",
                table: "AttendeeEvents",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvents_Events_EventId",
                table: "AttendeeEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestrictDates_Events_EventId",
                table: "RestrictDates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDates_Events_EventId",
                table: "SuggestedDates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAttendees_Teams_TeamId",
                table: "TeamAttendees",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
