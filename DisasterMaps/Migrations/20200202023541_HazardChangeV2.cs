using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterMaps.Migrations
{
    public partial class HazardChangeV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards");

            migrationBuilder.DropColumn(
                name: "HazId",
                table: "Hazards");

            migrationBuilder.AddColumn<long>(
                name: "Haz",
                table: "Hazards",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards",
                column: "Haz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards");

            migrationBuilder.DropColumn(
                name: "Haz",
                table: "Hazards");

            migrationBuilder.AddColumn<long>(
                name: "HazId",
                table: "Hazards",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards",
                column: "HazId");
        }
    }
}
