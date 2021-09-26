using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMeetup.Migrations
{
    public partial class times : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimesAlloweds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BeginningHour = table.Column<int>(type: "INTEGER", nullable: false),
                    BeginningMinute = table.Column<int>(type: "INTEGER", nullable: false),
                    EndingHour = table.Column<int>(type: "INTEGER", nullable: false),
                    EndingMinute = table.Column<int>(type: "INTEGER", nullable: false),
                    RestrictDateId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesAlloweds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimesAlloweds_RestrictDates_RestrictDateId",
                        column: x => x.RestrictDateId,
                        principalTable: "RestrictDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimesAlloweds_RestrictDateId",
                table: "TimesAlloweds",
                column: "RestrictDateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimesAlloweds");
        }
    }
}
