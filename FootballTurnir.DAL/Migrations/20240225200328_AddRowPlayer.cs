using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballTurnir.DAL.Migrations
{
    public partial class AddRowPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Player",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player",
                table: "Matches");
        }
    }
}
