using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterMaps.Migrations
{
    public partial class HazardChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Hazards");

            migrationBuilder.AddColumn<long>(
                name: "HazId",
                table: "Hazards",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards",
                column: "HazId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards");

            migrationBuilder.DropColumn(
                name: "HazId",
                table: "Hazards");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Hazards",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hazards",
                table: "Hazards",
                column: "Id");
        }
    }
}
