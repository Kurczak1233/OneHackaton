using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneHackaton.Infrastructure.Migrations
{
    public partial class teamId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DeveloperItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DeveloperItems");
        }
    }
}
