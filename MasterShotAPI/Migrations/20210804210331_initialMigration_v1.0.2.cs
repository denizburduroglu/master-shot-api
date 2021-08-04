using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterShotAPI.Migrations
{
    public partial class initialMigration_v102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imdbID",
                table: "Posts",
                newName: "ImdbID");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ImdbID",
                table: "Posts",
                newName: "imdbID");
        }
    }
}
