using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterMaps.Migrations
{
    public partial class AddedSplitCoor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "Stores");

            migrationBuilder.AddColumn<double>(
                name: "XCoordinates",
                table: "Stores",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "YCoordinates",
                table: "Stores",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XCoordinates",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "YCoordinates",
                table: "Stores");

            migrationBuilder.AddColumn<double>(
                name: "Coordinates",
                table: "Stores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
