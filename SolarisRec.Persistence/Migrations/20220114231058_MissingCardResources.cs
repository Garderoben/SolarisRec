using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class MissingCardResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[] { 36, 5, 3 });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[] { 36, 7, 2 });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[] { 42, 5, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 42, 5 });
        }
    }
}
