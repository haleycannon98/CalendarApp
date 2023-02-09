using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarAPI.Migrations
{
    /// <inheritdoc />
    public partial class CalendarMigrationEventUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Stickers_CalId",
                table: "Stickers");

            migrationBuilder.DropIndex(
                name: "IX_Notes_CalId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Events_CalId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CalId",
                table: "Stickers");

            migrationBuilder.DropColumn(
                name: "CalId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CalId",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "IdentityUser",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IdentityUser", x => x.Id);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_IdentityUser_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_IdentityUser_UserId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");

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

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

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
    }
}
