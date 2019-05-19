using Microsoft.EntityFrameworkCore.Migrations;

namespace IssuesTrackingSystem.Migrations
{
    public partial class updateEnumField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Issues",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Issues");
        }
    }
}
