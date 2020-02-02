using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterMaps.Migrations
{
    public partial class HazardDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Hazards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hazards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Hazards");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hazards");
        }
    }
}
