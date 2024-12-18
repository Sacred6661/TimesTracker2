using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesTracker2.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedDateStartEnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarted",
                table: "Projects",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DateStarted",
                table: "Projects");
        }
    }
}
