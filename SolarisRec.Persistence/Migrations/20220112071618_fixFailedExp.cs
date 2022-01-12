using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class fixFailedExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 127, 3 });

            migrationBuilder.UpdateData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 20, 7 },
                column: "Quantity",
                value: 2);

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[] { 127, 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 127, 4 });

            migrationBuilder.UpdateData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 20, 7 },
                column: "Quantity",
                value: 3);

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[] { 127, 3, 1 });
        }
    }
}
