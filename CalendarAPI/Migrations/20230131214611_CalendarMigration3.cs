using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarAPI.Migrations
{
    /// <inheritdoc />
    public partial class CalendarMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stickers_CalId",
                table: "Stickers",
                column: "CalId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CalId",
                table: "Notes",
                column: "CalId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CalId",
                table: "Events",
                column: "CalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Calendars_CalId",
                table: "Events",
                column: "CalId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Calendars_CalId",
                table: "Notes",
                column: "CalId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stickers_Calendars_CalId",
                table: "Stickers",
                column: "CalId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Calendars_CalId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Calendars_CalId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Stickers_Calendars_CalId",
                table: "Stickers");

            migrationBuilder.DropIndex(
                name: "IX_Stickers_CalId",
                table: "Stickers");

            migrationBuilder.DropIndex(
                name: "IX_Notes_CalId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Events_CalId",
                table: "Events");
        }
    }
}
