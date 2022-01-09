using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class MissingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[] { 36, 5 });

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[] { 42, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 42, 5 });
        }
    }
}
