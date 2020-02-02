using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterMaps.Migrations
{
    public partial class HazardMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XCoordinates",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "YCoordinates",
                table: "Stores");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Stores",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Stores",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Hazards",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    PosReport = table.Column<int>(nullable: false),
                    NegReport = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hazards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hazards");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Stores");

            migrationBuilder.AddColumn<double>(
                name: "XCoordinates",
                table: "Stores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "YCoordinates",
                table: "Stores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
