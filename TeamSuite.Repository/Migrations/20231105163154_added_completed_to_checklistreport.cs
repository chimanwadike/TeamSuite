using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamSuite.Repository.Migrations
{
    /// <inheritdoc />
    public partial class added_completed_to_checklistreport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "CheckListReports",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "CheckListReports");
        }
    }
}
