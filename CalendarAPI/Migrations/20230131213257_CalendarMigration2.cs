using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarAPI.Migrations
{
    /// <inheritdoc />
    public partial class CalendarMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalId",
                table: "Stickers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalId",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RepeatNum",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalId",
                table: "Stickers");

            migrationBuilder.DropColumn(
                name: "CalId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CalId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "RepeatNum",
                table: "Events");
        }
    }
}
