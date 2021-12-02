using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class contextupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_SuggestedDates_SuggestedDateId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SuggestedDateId",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "EventId",
                table: "SuggestedDates",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SuggestedDateId",
                table: "Events",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SuggestedDates_EventId",
                table: "SuggestedDates",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDates_Events_EventId",
                table: "SuggestedDates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDates_Events_EventId",
                table: "SuggestedDates");

            migrationBuilder.DropIndex(
                name: "IX_SuggestedDates_EventId",
                table: "SuggestedDates");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "SuggestedDates");

            migrationBuilder.AlterColumn<string>(
                name: "SuggestedDateId",
                table: "Events",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SuggestedDateId",
                table: "Events",
                column: "SuggestedDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_SuggestedDates_SuggestedDateId",
                table: "Events",
                column: "SuggestedDateId",
                principalTable: "SuggestedDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
