using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class CardEntitiesThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardFaction");

            migrationBuilder.AddColumn<string>(
                name: "ExpansionSerialNumber",
                table: "Cards",
                type: "VARCHAR(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Unique",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CardFactions",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    FactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFactions", x => new { x.CardId, x.FactionId });
                    table.ForeignKey(
                        name: "FK_CardFactions_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardFactions_Factions_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Ability", "AttackValue", "ExpansionId", "ExpansionSerialNumber", "HealthValue", "Name", "Type", "Unique" },
                values: new object[,]
                {
                    { 1, "Forced Reaction: When thisAgent enters play, put 2 traitor counters on it.\r\nForced Reaction: When this Agent would leave play, instead remove 1 traitor counter from this Agent,\r\nheal all of its damage and your opponent takes control of it.", 2, 1, "001", 2, "Turncoat", 1, false },
                    { 67, "Deal 1 damage to each Agent on a Mission.", null, 1, "067", null, "ChemicalWarfare", 3, false },
                    { 117, "Forced Reaction: After this card enters play put the top 5 cards of your deck under it face down\r\n[You may look at these cards any time.]\r\nUse: Play a card from under this card. When there are no cards left under this card, destroy it.", null, 1, "117", null, "Cyber Bank of Titan", 2, true },
                    { 159, "Discard your hand then draw 5 cards.", null, 1, "159", null, "Redistribution", 4, false }
                });

            migrationBuilder.UpdateData(
                table: "Factions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Belt");

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 67, 1 },
                    { 117, 3 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 67, 1, 1 },
                    { 67, 7, 1 },
                    { 117, 3, 2 },
                    { 117, 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 159, 4, 4 },
                    { 159, 5, 4 },
                    { 159, 7, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardFactions_FactionId",
                table: "CardFactions",
                column: "FactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardFactions");

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 67, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 117, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 117, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 159, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 159, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 159, 7 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DropColumn(
                name: "ExpansionSerialNumber",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Unique",
                table: "Cards");

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

            migrationBuilder.UpdateData(
                table: "Factions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Bel");

            migrationBuilder.CreateIndex(
                name: "IX_CardFaction_FactionsId",
                table: "CardFaction",
                column: "FactionsId");
        }
    }
}
