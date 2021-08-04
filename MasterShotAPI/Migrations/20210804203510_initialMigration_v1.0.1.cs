using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterShotAPI.Migrations
{
    public partial class initialMigration_v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imdbID",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imdbID",
                table: "Posts");
        }
    }
}
