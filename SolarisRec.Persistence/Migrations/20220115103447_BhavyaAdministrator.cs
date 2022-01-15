using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class BhavyaAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 5 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 6 },
                column: "Quantity",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 5 },
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 6 },
                column: "Quantity",
                value: 3);
        }
    }
}
