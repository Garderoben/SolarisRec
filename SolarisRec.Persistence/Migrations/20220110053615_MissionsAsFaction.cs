using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class MissionsAsFaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Factions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Include Missions" });

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[,]
                {
                    { 142, 7 },
                    { 143, 7 },
                    { 144, 7 },
                    { 145, 7 },
                    { 146, 7 },
                    { 147, 7 },
                    { 148, 7 },
                    { 149, 7 },
                    { 150, 7 },
                    { 151, 7 },
                    { 152, 7 },
                    { 153, 7 },
                    { 154, 7 },
                    { 155, 7 },
                    { 156, 7 },
                    { 157, 7 },
                    { 158, 7 },
                    { 159, 7 },
                    { 160, 7 },
                    { 161, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 142, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 143, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 144, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 145, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 146, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 147, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 148, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 149, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 150, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 151, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 152, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 153, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 154, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 155, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 156, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 157, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 158, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 159, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 160, 7 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 161, 7 });

            migrationBuilder.DeleteData(
                table: "Factions",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
