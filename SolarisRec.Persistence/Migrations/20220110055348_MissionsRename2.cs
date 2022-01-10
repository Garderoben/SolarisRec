using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class MissionsRename2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Factions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Mission");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Factions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Missions");
        }
    }
}
