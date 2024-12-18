using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesTracker2.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedTimeTrackerName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TimeTrackerName",
                table: "TimeTrackers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeTrackerName",
                table: "TimeTrackers");
        }
    }
}
