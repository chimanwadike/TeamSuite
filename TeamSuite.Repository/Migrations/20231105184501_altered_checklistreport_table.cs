using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamSuite.Repository.Migrations
{
    /// <inheritdoc />
    public partial class altered_checklistreport_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateString",
                table: "CheckListReports",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TimeString",
                table: "CheckListReports",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeekDay",
                table: "CheckListReports",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateString",
                table: "CheckListReports");

            migrationBuilder.DropColumn(
                name: "TimeString",
                table: "CheckListReports");

            migrationBuilder.DropColumn(
                name: "WeekDay",
                table: "CheckListReports");
        }
    }
}
