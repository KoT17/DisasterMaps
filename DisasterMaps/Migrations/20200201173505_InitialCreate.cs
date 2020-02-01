using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterMaps.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Coordinates = table.Column<double>(nullable: false),
                    ClosingTime = table.Column<DateTime>(nullable: false),
                    OpeningTime = table.Column<DateTime>(nullable: false),
                    IsOpen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
