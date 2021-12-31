using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class CardEntitiesTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpansionId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CardFaction",
                columns: table => new
                {
                    CardsId = table.Column<int>(type: "int", nullable: false),
                    FactionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFaction", x => new { x.CardsId, x.FactionsId });
                    table.ForeignKey(
                        name: "FK_CardFaction_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardFaction_Factions_FactionsId",
                        column: x => x.FactionsId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardResources",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardResources", x => new { x.CardId, x.ResourceId });
                    table.ForeignKey(
                        name: "FK_CardResources_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardResources_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ExpansionId",
                table: "Cards",
                column: "ExpansionId");

            migrationBuilder.CreateIndex(
                name: "IX_CardFaction_FactionsId",
                table: "CardFaction",
                column: "FactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CardResources_ResourceId",
                table: "CardResources",
                column: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Expansions_ExpansionId",
                table: "Cards",
                column: "ExpansionId",
                principalTable: "Expansions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Expansions_ExpansionId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "CardFaction");

            migrationBuilder.DropTable(
                name: "CardResources");

            migrationBuilder.DropIndex(
                name: "IX_Cards_ExpansionId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ExpansionId",
                table: "Cards");
        }
    }
}
