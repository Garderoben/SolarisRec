using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class CardEntitiesOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Ability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    AttackValue = table.Column<int>(type: "int", nullable: true),
                    HealthValue = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expansions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expansions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardTalents",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    TalentId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTalents", x => new { x.CardId, x.TalentId });
                    table.ForeignKey(
                        name: "FK_CardTalents_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardTalents_Talents_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Expansions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "So it Begins" });

            migrationBuilder.InsertData(
                table: "Factions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mars" },
                    { 2, "Mercury" },
                    { 3, "Titan" },
                    { 4, "Bel" },
                    { 5, "Earth" },
                    { 6, "Venus" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Martian" },
                    { 2, "Mercurian" },
                    { 3, "Titanian" },
                    { 4, "Beltian" },
                    { 5, "Earthian" },
                    { 6, "Venusian" },
                    { 7, "Any" }
                });

            migrationBuilder.InsertData(
                table: "Talents",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Yellow" },
                    { 2, "Blue" },
                    { 3, "Red" },
                    { 4, "Black" },
                    { 5, "Green" },
                    { 6, "Purple" },
                    { 7, "Any" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardTalents_TalentId",
                table: "CardTalents",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_Expansions_Name",
                table: "Expansions",
                column: "Name",
                unique: true)
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Factions_Name",
                table: "Factions",
                column: "Name",
                unique: true)
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Resources_Name",
                table: "Resources",
                column: "Name",
                unique: true)
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Talents_Name",
                table: "Talents",
                column: "Name",
                unique: true)
                .Annotation("SqlServer:Clustered", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTalents");

            migrationBuilder.DropTable(
                name: "Expansions");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Talents");
        }
    }
}
