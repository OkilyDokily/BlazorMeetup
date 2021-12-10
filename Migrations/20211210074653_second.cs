using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class second : Migration
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
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_RestrictDates_Events_EventId",
                table: "RestrictDates");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDates_RestrictDates_RestrictDateId",
                table: "SuggestedDates");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_Teams_TeamId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAvatarSettings_Teams_TeamId",
                table: "TeamAvatarSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds");

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
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
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
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees",
                column: "SuggestedDateId",
                principalTable: "SuggestedDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDates_RestrictDates_RestrictDateId",
                table: "SuggestedDates",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
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
                name: "FK_TeamAvatarSettings_Teams_TeamId",
                table: "TeamAvatarSettings",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
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
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_RestrictDates_Events_EventId",
                table: "RestrictDates");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDates_RestrictDates_RestrictDateId",
                table: "SuggestedDates");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_AspNetUsers_AttendeeId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAttendees_Teams_TeamId",
                table: "TeamAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAvatarSettings_Teams_TeamId",
                table: "TeamAvatarSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds");

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
                name: "FK_AvatarSettings_AspNetUsers_AttendeeId",
                table: "AvatarSettings",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AttendeeId",
                table: "Events",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
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
                name: "FK_Servers_AspNetUsers_AttendeeId",
                table: "Servers",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_AspNetUsers_AttendeeId",
                table: "SuggestedDateAttendees",
                column: "AttendeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDateAttendees_SuggestedDates_SuggestedDateId",
                table: "SuggestedDateAttendees",
                column: "SuggestedDateId",
                principalTable: "SuggestedDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDates_RestrictDates_RestrictDateId",
                table: "SuggestedDates",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAvatarSettings_Teams_TeamId",
                table: "TeamAvatarSettings",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                table: "TimesAlloweds",
                column: "RestrictDateId",
                principalTable: "RestrictDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
