using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarisRec.Persistence.Migrations
{
    public partial class AllCardsSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Chemical Warfare");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Ability", "AttackValue", "ExpansionId", "ExpansionSerialNumber", "HealthValue", "Name", "Type", "Unique" },
                values: new object[,]
                {
                    { 2, "Reaction: After this Agent leaves play, draw 1 card.", 1, 1, "002", 1, "Insured Colleague", 1, false },
                    { 3, "Reaction: After this Agent leaves play, look at the top 2 cards of your deck,\r\nput one of them into your hand and the other to the bottom of your deck.", 0, 1, "003", 1, "Beggar Informator", 1, false },
                    { 4, "Reaction, [B][B][A2]: After this Agent deals attack damage to an Agent, destroy that Agent.", 2, 1, "004", 2, "Koronis Belter", 1, false },
                    { 5, "Sacrifice: Target Agent loses a Talent of your choice on this Mission until the end of the phase.", 2, 1, "005", 2, "Concubine", 1, false },
                    { 6, "Use, Sacrifice an Agent on this Mission: Target opponent sacrifices an Agent on this Mission,\r\nthen you draw 1 Card", 2, 1, "006", 4, "Madame Kyung", 1, true },
                    { 7, "[B][A2]: This Agent gains [Data] or [Mining] until the end of the phase.", 2, 1, "007", 3, "Phisher", 1, false },
                    { 8, "Reaction: Cancel the first attack targeting this Agent in the Conflict phase.", 3, 1, "008", 1, "Vesta Extortionist", 1, false },
                    { 9, "Reaction: After this Agent leaves play, put a 2/2 Scum Agent token\r\nwith [Espionage] into play on the same Area.", 1, 1, "009", 1, "Young Scum", 1, false },
                    { 10, "[B][B][A3], Use: Put a 2/2 Scum Agent token with [Espionage] into play\r\non the same Area.", 4, 1, "010", 3, "Vesta Thug", 1, false },
                    { 11, "Sacrifice: Destroy target Construction", 3, 1, "011", 4, "Rebel Saboteur", 1, false },
                    { 12, "Conflict action, Use: Target enemy Agent\r\non this Mission moves to another Ready\r\nMission, if there are no Ready Missions,\r\nthen move that Agent to the Shuttle area.", 2, 1, "012", 4, "Gang Leader", 1, false },
                    { 13, "Reaction: After a friendly\r\nnon-token Agent leaves play,\r\nput 1 Influence on this Agent.", 3, 1, "013", 4, "Mr. Yué", 1, true },
                    { 14, "When you play this card, attach it to an Agent and\r\nput 1 infection counter on this card.\r\nReaction: At the beginning of the Starting phase put\r\n1 infection counter on this card. If there are equal or\r\nmore infection counters on this card as the\r\nconverted Resource cost of the attached Agent,\r\ndestroy that Agent.", null, 1, "014", null, "Growing Infection", 3, false },
                    { 15, "Syndicate Maneuver\r\nDestroy target Agent.", null, 1, "015", null, "Execution", 3, false },
                    { 16, "Reaction: After an Agent you control\r\ndeals attack damage to a non-Unique\r\nAgent, destroy that Agent.", null, 1, "016", null, "Hunt Down", 3, false },
                    { 17, "Sacrifice an Agent: Prevent all damage\r\nfrom one source to an Agent on the\r\nsame Mission.", null, 1, "017", null, "Organ Donor", 3, false },
                    { 18, "Move target used enemy Agent to a Ready\r\nMission, if there are no Ready Missions, then\r\nmove that Agent to the Shuttle area.", null, 1, "018", null, "You are Tired!", 3, false },
                    { 19, "Syndicate Maneuver\r\nAll players destroy 1 Agent\r\nin all their Shuttles.", null, 1, "019", null, "Eye for an Eye", 3, false },
                    { 20, "Syndicate Maneuver\r\nSacrifice an Agent: Destroy target\r\nAgent or Construction.", null, 1, "020", null, "Arson", 3, false },
                    { 21, "Syndicate Maneuver\r\nPut three 2/2 Scum Agent tokens\r\nwith [Espionage] into a Shuttle.", null, 1, "021", null, "Best of the Belt", 3, false },
                    { 22, "Use, Sacrifice a non-token Agent:\r\nDraw 1 card.", null, 1, "022", null, "Donor center", 2, true },
                    { 23, "Use: Use target Agent\r\nunless its controller pays [A2].", null, 1, "023", null, "Asteroid Intel Station", 2, false },
                    { 24, "Syndicate action, Use, Discard a\r\ncard: Put a +1/+1 counter on this\r\nAgent", 0, 1, "024", 1, "Acolyte in Training", 1, false },
                    { 25, "Reaction: After this Agent leaves\r\nplay, put a +1/+1 counter on target\r\nAgent on the same area.", 1, 1, "025", 1, "Monk of Sol", 1, false },
                    { 26, "Reaction: After this Agent enters\r\nplay draw 1 card.", 1, 1, "026", 2, "Sanctioned Priest", 1, false },
                    { 27, "[E][E][A1]: Increase a Talent\r\nrequirement on this Mission by 1\r\nuntil the end of the phase.", 2, 1, "027", 2, "Earthseed Activist", 1, false },
                    { 28, "Reaction: After this Agent enters play\r\nput the top card of your deck under it\r\nface down. At the beginning of the\r\nStarting phase, draw that card.", 1, 1, "028", 1, "Peaceful Representative", 1, false },
                    { 29, "Conflict action, Use: Move this Agent\r\nand a non-Unique enemy Agent on this\r\nMission with converted Resource cost 3\r\nor lower to the Shuttle area.", 0, 1, "029", 2, "Revered Mediator", 1, false },
                    { 30, "Reaction: After this Agent\r\ncompletes a Mission, draw 1 card.", 3, 1, "030", 3, "Negotiator Eld", 1, true },
                    { 31, "While this Agent is ready, it takes 1\r\nless damage from any source.", 2, 1, "031", 3, "Exiled Paladin", 1, false },
                    { 32, "Reaction: After this Agent enters play\r\nput the top card of your deck under it\r\nface down. At the beginning of the\r\nStarting phase, draw that card.", 3, 1, "032", 2, "Investigator Paladin", 1, false },
                    { 33, "Reaction: After another Agent is\r\nassigned attack damage on this Mission\r\nyou may reassign it to this Agent.", 1, 1, "033", 6, "Guardian Paladin", 1, false },
                    { 34, "Reaction: After this Agent\r\ncompletes a Mission gain 1\r\nInfluence.", 4, 1, "034", 3, "Political Advisor", 1, false },
                    { 35, "[E][E][A2]: Target Agent on a ready\r\nMission gains a Talent of your\r\nchoice until the end of the phase.", 3, 1, "035", 4, "CosmicLink Manager", 1, false },
                    { 36, "This Agent cannot be targeted by Conflict\r\nactions if there are any other friendly Agents on\r\nthis Mission.\r\nConflict Action, Use: Return target non-Unique\r\nenemy Agent on this Mission to its owners hand.", 0, 1, "036", 5, "Ambassador Sunders", 1, true },
                    { 37, "Reaction: After an attack is declared\r\nagainst an Agent you control, choose a\r\nnew defender.", null, 1, "037", null, "Heroic Rescue", 3, false },
                    { 38, "Reaction: Prevent all damage on an\r\nAgent from a source that deals 3 or\r\nmore damage.", null, 1, "038", null, "Saw it Coming", 3, false },
                    { 39, "Reaction: Prevent 2 damage", null, 1, "039", null, "Expendable Bodyguard", 3, false },
                    { 40, "Return target non-Unique Agent with\r\nconverted Resource cost 3 or lower to its\r\nowners hand.", null, 1, "040", null, "Introducing to The Faith", 3, false },
                    { 41, "Conflict action, Use target Agent:\r\nMove target friendly Agent and a\r\nnon-Unique enemy Agent on the same\r\nMission with converted Resource cost 3 or\r\nlower to the Shuttle area.", null, 1, "041", null, "Can't Touch Me", 3, false },
                    { 42, "Attach this card to a Mission. Increase all\r\nTalent requirements on this Mission by 1.\r\nForced Reaction: After completing this\r\nMission, destroy this card.", null, 1, "042", null, "Hard Times", 3, false }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Ability", "AttackValue", "ExpansionId", "ExpansionSerialNumber", "HealthValue", "Name", "Type", "Unique" },
                values: new object[,]
                {
                    { 43, "Change a Talent requirement on a\r\nMission until the end of round.", null, 1, "043", null, "Twist of Fate", 3, false },
                    { 44, "Destroy all Agents\r\non target Mission.", null, 1, "044", null, "Scorched Earth Tactic", 3, false },
                    { 45, "Choose up to 3 Agents,\r\nthey gain [Diplomacy] until the\r\nend of the phase.", null, 1, "045", null, "Political Delegation", 3, false },
                    { 46, "Preparing.\r\n[This card enters play Used.]\r\nSyndicate action, Use:\r\nPut an 1/1 Envoy Agent token\r\nwith [Diplomacy] into play.", null, 1, "046", null, "Political Academy", 2, false },
                    { 47, "Use: Choose a Talent on another Agent\r\non this Mission, give that Agent on more\r\nof that Talent until the end of the phase.", 0, 1, "047", 2, "Martian Diplomat", 1, false },
                    { 48, "Reaction: After this Agent leaves\r\nplay, each player deals 1 damage\r\nto target enemy Agent on this\r\nMission.", 1, 1, "048", 1, "Crimson Grenadier", 1, false },
                    { 49, "Reaction: After this Agent leaves play,\r\nsearch your deck for a card named\r\nCrimson Legion Infantry, reveal it and\r\nadd it to your hand. Shuffle.", 1, 1, "049", 1, "Crimson Legion Infantry", 1, false },
                    { 50, "Reaction, [Ma]: After this Agent is\r\ndeployed to a Mission, search your deck\r\nor hand for a card named Special Ops,\r\nput it into play on this Mission Used.\r\nShuffle.\r\n[Limit once per phase.]", 2, 1, "050", 1, "Special Ops", 1, false },
                    { 51, "[Ma][A1]: This Agent gains\r\n+1/+0 until the end of the phase.", 2, 1, "051", 2, "Crimson Shock Troops", 1, false },
                    { 52, "Reaction: After this Agent leaves play,\r\ntarget Agent gains a Talent of your\r\nchoice until the end of the phase.", 2, 1, "052", 1, "Crimson Legion Scout", 1, false },
                    { 53, "Reaction: After this Agent deals\r\nattack damage to an enemy Agent,\r\ndeal 1 damage to target Agent on\r\nthis Mission.", 3, 1, "053", 3, "Sergeant Joseph", 1, true },
                    { 54, "[Ma][Ma][A1]: Deal 1 damage\r\nto target Agent on this Mission.", 2, 1, "054", 2, "Chefu Militia", 1, false },
                    { 55, "[Ma][Ma]: This Agent gains [Military]\r\nuntil the end of this phase.", 3, 1, "055", 2, "Tarakan Guard", 1, false },
                    { 56, "[A2]: This Agent gains a Talent of\r\nyour choice until the end\r\nof the phase.", 2, 1, "056", 3, "Chameleon Corps", 1, false },
                    { 57, "Reaction: After this Agent is deployed\r\nto a Mission, deal 1 damage to each\r\nenemy Agent on this Mission.", 2, 1, "057", 2, "Explosive Expert", 1, false },
                    { 58, "Reaction: After this Agent is deployed\r\nto a Mission, look at the top 3 cards of\r\nyour deck, you may reveal an Agent\r\ncard and add it to your hand. Shuffle.", 4, 1, "058", 3, "Supply Line Officer", 1, false },
                    { 59, "[Ma][Ma][A2]: Deal 2 damage\r\nto target agent on this Mission.", 4, 1, "059", 3, "Irharen Veteran", 1, false },
                    { 60, "Reaction: After this Agent is deployed to\r\na Mission, put a 1/1 Infantry Agent token\r\nwith [Military] into play on this Mission.", 3, 1, "060", 6, "General Rwanda", 1, true },
                    { 61, "Hasty\r\n[If you play this card during the\r\nConflict phase, pay [A1] more.]\r\nDeal 2 damage to target Agent.", null, 1, "061", null, "Headshot", 3, false },
                    { 62, "Conflict Maneuver\r\nUse an Agent: Deal its attack value to\r\ntarget Agent on the same mission.", null, 1, "062", null, "Prepared Ambush", 3, false },
                    { 63, "Conflict Maneuver\r\nTarget friendly Agent deals its attack value to\r\ntarget Agent on the same mission.", null, 1, "063", null, "Unexpected Courage", 3, false },
                    { 64, "Reaction: After completing a Mission,\r\ndraw 3 cards.\r\n[Limit once per mission.]", null, 1, "064", null, "Devoted Learning", 3, false },
                    { 65, "Target Agent gains a Talent of your\r\nchoice until the end of the phase.", null, 1, "065", null, "Martian Education", 3, false },
                    { 66, "Reaction: After completing a Mission,\r\ndeal 3 damage to target Agent in play.", null, 1, "066", null, "Aftermath", 3, false },
                    { 68, "Reaction: After you claim a Mission,\r\ninstead of your opponent, you put the new\r\nMission from your Mission Deck into play.", null, 1, "068", null, "War Propaganda", 3, false },
                    { 69, "Use: Target Agent gains a\r\nTalent of your choice\r\nuntil the end of the phase.", null, 1, "069", null, "Olympus University", 2, true },
                    { 70, "Preparing.\r\n[This Agent enters play Used.]\r\nUse: Gain [Me].", 0, 1, "070", 1, "Mercurian Recruiter", 1, false },
                    { 71, "[A2]: Take control of this Agent.\r\n[Any player may pay for this ability.]", 2, 1, "071", 2, "Apollodorus Merc", 1, false },
                    { 72, "Use, [Me][Me][A2]: Destroy target\r\nConstruction.", 2, 1, "072", 2, "New Dallas Sapper", 1, false },
                    { 73, "Reaction: After this Agent enters\r\nplay, ready one of your Resource\r\ncards.", 1, 1, "073", 2, "Second Gen. Colonist", 1, false },
                    { 74, "Spend 1 influence: Gain\r\n[Me][Me][Me] you can only spend this\r\nResource to play Construction cards.", 2, 1, "074", 4, "Noah, the Architect", 1, true },
                    { 75, "[Me][Me]: This Agent gains [Mining]\r\nuntil the end of the phase.", 3, 1, "075", 2, "MiningBeliever", 1, false },
                    { 76, "Reaction, [A2]: After this Agent\r\ncompletes a Mission, gain 1\r\nInfluence.", 2, 1, "076", 3, "New Dallas Opportunist", 1, false },
                    { 77, "Reaction: After you have 0 ready\r\nResource cards the first time\r\nduring your turn, gain 1 Influence.", 2, 1, "077", 3, "Caloris Basin Trader", 1, false },
                    { 78, "[Me][Me][A2]: Gain +1/+1 until the\r\nend of the phase.", 4, 1, "078", 3, "A.M.U.", 1, false },
                    { 79, "Reaction: After this Agent enters\r\nplay, put a Resource card of your\r\nchoice into play Used.", 2, 1, "079", 2, "Outcast Smuggler", 1, false },
                    { 80, "Use: Gain 1 Influence.", 0, 1, "080", 5, "Mining Walker", 1, false },
                    { 81, "Reaction: At the start of the\r\nConflict phase, gain [A1] for each\r\nConstruction you control.", 4, 1, "081", 5, "Bobby McKendrick, The Boss", 1, true },
                    { 82, "Target Agent gains +2/+2\r\nuntil the end of the Conflict round.", null, 1, "082", null, "Combat Steroids", 3, false },
                    { 83, "Ready target Agent on a Mission.", null, 1, "083", null, "Give Up or Get Up!", 3, false },
                    { 84, "Reaction: After your opponent plays a card, you\r\nmay pay the card's converted Resource cost\r\ninstead, gain Influence equal to the cost payed.\r\n[up to 3 Influence.]", null, 1, "084", null, "Give Up or Get Up!", 3, false },
                    { 85, "You can only play this card if you have 3 or more\r\nready Resource cards.\r\nReaction: Cancel target Maneuver card, that is\r\ntargeting one of your Agents or Constructions.", null, 1, "085", null, "Nabu Insurance Policy", 3, false }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Ability", "AttackValue", "ExpansionId", "ExpansionSerialNumber", "HealthValue", "Name", "Type", "Unique" },
                values: new object[,]
                {
                    { 86, "Syndicate maneuver\r\nPut a Resource card of your\r\nchoice into play Used.", null, 1, "086", null, "Investment in the Future", 3, false },
                    { 87, "Syndicate maneuver\r\nPut a Mercury Resource\r\ncard into play Used.", null, 1, "087", null, "Recycle Everything that Shines", 3, false },
                    { 88, "Syndicate maneuver\r\nDestroy target Construction", null, 1, "088", null, "Planned Demolition", 3, false },
                    { 89, "Syndicate maneuver\r\nTarget Shuttle cannot be deployed this\r\nround.", null, 1, "089", null, "Bad Quality Fuel Cells", 3, false },
                    { 90, "This card can't have more than\r\n3 material counters on it.\r\nUse a Resource card: Put a material counter on\r\nthis card.\r\nUse: Remove all material counters from this card to\r\ngain that many [A].", null, 1, "090", null, "Calor Storage", 2, false },
                    { 91, "Use, [Me][A1]:\r\nDraw 1 card.", null, 1, "091", null, "Apollodorus Dock", 2, true },
                    { 92, "[A2]: Gain 1 Influence.\r\n[Limit once per phase.]", null, 1, "092", null, "Walking Factory", 2, false },
                    { 93, "Reaction, Use: At the start of the\r\nConflict phase target Agent gains\r\n+1/+0 until the end of the phase.", null, 1, "093", null, "Gearing Station", 2, false },
                    { 94, "Use: Discard the\r\ntop 2 cards of your deck.", 0, 1, "094", 2, "Data Miner", 1, false },
                    { 95, "Archive.\r\n[You can play this card as a Resource from your\r\ndiscard pile.]", 2, 1, "095", 2, "Ordinary Servitor", 1, false },
                    { 96, "Conflict action, Use: Take control of\r\ntarget non-Unique Agent on this Mission\r\nwith converted Resource cost 3 or lower\r\nuntil the end of the phase or until this\r\ncard leaves this Mission. This Agent\r\ncannot ready until the end of the Round.", 0, 1, "096", 2, "Sinlap Parasyte", 1, false },
                    { 97, "Reaction: After this Agent enters play\r\nreturn target card from your discard\r\npile to the top of your deck. Shuffle.", 2, 1, "097", 2, "Oracle Droid", 1, false },
                    { 98, "Reaction: After this Agent deals\r\ndamage to an enemy Agent, that Agent\r\nloses all of its Talents until the end of\r\nthe phase.", 2, 1, "098", 4, "Ebony Franth", 1, true },
                    { 99, "Archive.\r\n[You can play this card as a Resource from your\r\ndiscard pile.]", 2, 1, "099", 3, "Battle Droid", 1, false },
                    { 100, "Reaction: At the start of the Conflict\r\nphase, give target Agent on this Mission\r\n+1/+1 until the end of the phase.", 2, 1, "100", 2, "Ligeia Developer", 1, false },
                    { 101, "Reaction: After this Agent enters play\r\nreveal the top 5 cards of your deck. You\r\nmay choose a Maneuver card among\r\nthem and put it into your hand.\r\nDiscard the rest.", 3, 1, "101", 3, "Xanadu Lead Librarian", 1, false },
                    { 102, "Archive.\r\nReaction: After this agent enters play\r\nchoose a non-Unique Agent with converted\r\nResource cost 3 or lower in your discard pile.\r\nPut that Agent into play with a +1/+1 counter\r\non it, it gains a [Data]. attach Lazarus Protocol\r\nto that Agent.", 0, 1, "102", 0, "Lazarus Protocol", 1, false },
                    { 103, "Archive.\r\n[You can play this card as a Resource from your\r\ndiscard pile.]", 3, 1, "103", 4, "Cyborg Bodyguard", 1, false },
                    { 104, "Reaction: After this agent deals\r\nattack damage discard a random\r\ncard from your opponent's hand.", 3, 1, "104", 5, "Bhavya, Administrator", 1, true },
                    { 105, "Reaction: After an Agent is dealt attack\r\ndamage, that Agent loses all of its\r\nTalents until the end of the phase.", null, 1, "105", null, "Illusional Distraction", 3, false },
                    { 106, "Archive.\r\n[You can play this card as a Resource from your discard pile.]\r\nUse target Agent with converted\r\nResource cost 3 or lower.", null, 1, "106", null, "Fatigue of the Flesh", 3, false },
                    { 107, "Use target Agent:\r\nReady another target Agent.", null, 1, "107", null, "Interplanetary Assist", 3, false },
                    { 108, "Conflict action: Ready target non-Unique\r\nenemy Agent with converted Resource\r\ncost 3 or lower, take control of it and\r\nimmediately make an Attack with that Agent.\r\nReturn it to its owner's control.", null, 1, "108", null, "Sudden Turnaround", 3, false },
                    { 109, "Archive.\r\n[You can play this card as a Resource from your discard pile.]\r\nTarget Agent treats its text box as if it were\r\nblan until the end of the phase.", null, 1, "109", null, "Silence Your Mind", 3, false },
                    { 110, "Target opponent reveals their hand.\r\nYou choose a card from it.\r\nThat player discards that card.", null, 1, "110", null, "Data Breach", 3, false },
                    { 111, "Archive.\r\nChoose a non-Unique Agent in play,\r\ntake control of that Agent\r\nuntil the end of the phase.", null, 1, "111", null, "Mind Override", 3, false },
                    { 112, "Target Agent loses a Talent of your\r\nchoice until the end of the round.", null, 1, "112", null, "Wipe the Mind", 3, false },
                    { 113, "Archive.\r\nSearch your discard pile for an Agent\r\ncard, put it into your hand.", null, 1, "113", null, "Searching the Archives", 3, false },
                    { 114, "Discard the top 5 cards\r\nof your deck.", null, 1, "114", null, "Ancient Drives", 3, false },
                    { 115, "Reaction: After this card enters play put 4\r\nmemory counters on it.\r\nUse, Remove a memory counter:\r\nLook at the top card of your deck.\r\nYou may put that card into your Discard pile.", null, 1, "115", null, "Data Mine", 2, false },
                    { 116, "Use: Put 1 corruption counter on this card.\r\nUse: Take control of an Agent with converted\r\nResource cost equal to the corruption counters\r\non this card. Destroy this card.", null, 1, "116", null, "Xanadu Memory Vault", 2, true },
                    { 118, "Covert.\r\n[This Agent can be played in\r\nthe Conflict phase.]", 1, 1, "118", 1, "Disguised Crew", 1, false },
                    { 119, "Forced Reaction: Destroy this\r\nAgent at the end of the round.", 2, 1, "119", 2, "Dust Addict", 1, false },
                    { 120, "Covert.\r\n[This Agent can be played in\r\nthe Conflict phase.]", 2, 1, "120", 1, "Discipline of Night", 1, false },
                    { 121, "[V]: This Agent gains a Talent of your\r\nchoice from an enemy Agent on the\r\nsame Mission until the end of the phase.", 2, 1, "121", 2, "Evidence Analyst", 1, false },
                    { 122, "Reaction: After a friendly Agent\r\nmoves to this Mission,\r\ndraw 1 card. [limit once per phase]", 3, 1, "122", 3, "Quasim Daher", 1, true },
                    { 123, "[V][V][A1]: In the Conflict phase,\r\nmoves target friendly Agent\r\nto the Shuttle area.", 2, 1, "123", 3, "Ishtar Associate", 1, false },
                    { 124, "Use: When this Agent is on a\r\nMission, move this Agent to a\r\nReady Mission.", 2, 1, "124", 2, "Traveling Merchant", 1, false },
                    { 125, "Covert.\r\n[This Agent can be played in the\r\nConflict phase.]", 3, 1, "125", 2, "Hidden Cell", 1, false },
                    { 126, "Reaction: After a friendly Agent\r\nenters play on this Mission,\r\nready this Agent.", 3, 1, "126", 4, "Maat Mons Supervisor", 1, false },
                    { 127, "[V][V][A2]: Prevent all damage\r\nfrom a source on this Agent.", 6, 1, "127", 1, "Failed Experiment", 1, false },
                    { 128, "Covert.\r\nReaction: When this Agent enters play\r\nin the Conflict phase,\r\nCancel target card.", 3, 1, "128", 2, "Mole", 1, false }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Ability", "AttackValue", "ExpansionId", "ExpansionSerialNumber", "HealthValue", "Name", "Type", "Unique" },
                values: new object[,]
                {
                    { 129, "Reaction, Use: If this is the only Agent\r\nin this shuttle, after the Shuttle Dials\r\nare revealed change the number of\r\nthis Agent's Shuttle Dial.", 3, 1, "129", 3, "Famed Navigator", 1, false },
                    { 130, "Reaction: After this Agent completes a\r\nMission move this Agent to the next\r\nMission. [Limit once per phase.]", 3, 1, "130", 4, "Violet Thorn", 1, true },
                    { 131, "Reaction: Cancel target card,\r\nunless the controlling player pays [A2].", null, 1, "131", null, "Unexpected Expenses", 3, false },
                    { 132, "Syndicate maneuver\r\nReaction: Cancel target card.", null, 1, "132", null, "Failed Project", 3, false },
                    { 133, "Reaction: After a friendly Agent with\r\nCovert enters play, it deals its attack\r\nvalue to target Agent on the same mission.", null, 1, "133", null, "Act of Aggression", 3, false },
                    { 134, "Reaction: After the Shuttle dials are\r\nrevealed, change the number on a\r\nShuttle dial you control.", null, 1, "134", null, "Forged Travel Log", 3, false },
                    { 135, "Search the top 5 cards of your deck\r\nfor a card and put it into your hand.\r\nPut the rest to the bottom of your deck.", null, 1, "135", null, "Intel Gathering", 3, false },
                    { 136, "Reaction: After a friendly Agent is dealt\r\ndamage from an enemy Agent,\r\ndeal the same amount of damage to that\r\nAgent, up to this Agent's health.", null, 1, "136", null, "Toxic Blood", 3, false },
                    { 137, "Reaction: Prevent all damage\r\nfrom one source on an Agent.", null, 1, "137", null, "Hologram Trick", 3, false },
                    { 138, "Conflict maneuver\r\nMove target friendly Agent to\r\nthe Shuttle area.", null, 1, "138", null, "I'm Out of Here!", 3, false },
                    { 139, "Rearrange all friendly Agents\r\nin your Shuttles.", null, 1, "139", null, "Misinformation", 3, false },
                    { 140, "Use: You may play an Agent in this\r\nphase as a Maneuver.", null, 1, "140", null, "Infiltration Academy", 2, false },
                    { 141, "Reaction, Use: After a friendly Agent\r\nenters play in the Conflict phase,\r\ndraw 1 card.", null, 1, "141", null, "The Shadow District", 2, true },
                    { 142, "Draw 2 cards then discard 1.", null, 1, "142", null, "Recon Intel", 4, false },
                    { 143, "Destroy target Construction.", null, 1, "143", null, "Deconstruction", 4, false },
                    { 144, "Choose target Mission in the Mission Row, switch that Mission with one from\r\nyour Mission Deck- [The other one goes back to its owner's Mission Deck.]", null, 1, "144", null, "Mission Swap", 4, false },
                    { 145, "Destroy target Resource card.", null, 1, "145", null, "Industrial Sabotage", 4, false },
                    { 146, "Each player gains 3 Influence.", null, 1, "146", null, "Peace Agreement", 4, false },
                    { 147, "Each player loses 4 Influence.", null, 1, "147", null, "Collapsing Stocks", 4, false },
                    { 148, "Draw 1 card, target opponent discards 1 card.", null, 1, "148", null, "Server Overload", 4, false },
                    { 149, "Destroy target Agent with converted Resource cost 3 or lower.", null, 1, "149", null, "Framing", 4, false },
                    { 150, "Target player reveals their hand. You choose a card from it.\r\nThat player discards that card.", null, 1, "150", null, "Wiretapping", 4, false },
                    { 151, "Put a Resource card of your choice into play.", null, 1, "151", null, "Careful Planning", 4, false },
                    { 152, "Put an Agent into your Shuttle area from your discard pile with\r\nconverted Resource cost 3 or less.", null, 1, "152", null, "Resource Operation", 4, false },
                    { 153, "After you claim this Mission, instead of your opponent, you put\r\nthe new Mission from your Mission Deck into play.", null, 1, "153", null, "My Way!", 4, false },
                    { 154, "You may spend up to 3 Influence to draw that many cards.", null, 1, "154", null, "Calling in Favors", 4, false },
                    { 155, "Destroy all Agents in play.", null, 1, "155", null, "Level the Playing Field", 4, false },
                    { 156, "Put an Agent into your Shuttle area from your hand.", null, 1, "156", null, "Mustering", 4, false },
                    { 157, "Take control of target non-Unique Agent.", null, 1, "157", null, "Seduction", 4, false },
                    { 158, "Choose up to 2 Maneuver cards from your discard pile\r\nand put them into your hand.", null, 1, "158", null, "Withdraw Funds", 4, false },
                    { 160, "Draw 1 card. Gain 2 Influence.", null, 1, "160", null, "Search for Lost Knowledge", 4, false },
                    { 161, "Target player discards 1 card from their hand.\r\nGain 2 Influence.", null, 1, "161", null, "Planetary Politics", 4, false }
                });

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Mining");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Data");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Military");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Espionage");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Diplomacy");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Research");

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[,]
                {
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 },
                    { 6, 4 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 4 },
                    { 10, 4 },
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 4 },
                    { 14, 4 },
                    { 15, 4 },
                    { 16, 4 },
                    { 17, 4 },
                    { 18, 4 },
                    { 19, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 22, 4 },
                    { 23, 4 },
                    { 24, 5 },
                    { 25, 5 },
                    { 26, 5 },
                    { 27, 5 },
                    { 28, 5 },
                    { 29, 5 },
                    { 30, 5 },
                    { 31, 5 },
                    { 32, 5 },
                    { 33, 5 },
                    { 34, 5 },
                    { 35, 5 },
                    { 37, 5 },
                    { 38, 5 },
                    { 39, 5 },
                    { 40, 5 },
                    { 41, 5 },
                    { 43, 5 },
                    { 44, 5 },
                    { 45, 5 }
                });

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[,]
                {
                    { 46, 5 },
                    { 47, 1 },
                    { 48, 1 },
                    { 49, 1 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 1 },
                    { 53, 1 },
                    { 54, 1 },
                    { 55, 1 },
                    { 56, 1 },
                    { 57, 1 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 1 },
                    { 64, 1 },
                    { 65, 1 },
                    { 66, 1 },
                    { 68, 1 },
                    { 69, 1 },
                    { 70, 2 },
                    { 71, 2 },
                    { 72, 2 },
                    { 73, 2 },
                    { 74, 2 },
                    { 75, 2 },
                    { 76, 2 },
                    { 77, 2 },
                    { 78, 2 },
                    { 79, 2 },
                    { 80, 2 },
                    { 81, 2 },
                    { 82, 2 },
                    { 83, 2 },
                    { 84, 2 },
                    { 85, 2 },
                    { 86, 2 },
                    { 87, 2 },
                    { 88, 2 }
                });

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[,]
                {
                    { 89, 2 },
                    { 90, 2 },
                    { 91, 2 },
                    { 92, 2 },
                    { 93, 2 },
                    { 94, 3 },
                    { 95, 3 },
                    { 96, 3 },
                    { 97, 3 },
                    { 98, 3 },
                    { 99, 3 },
                    { 100, 3 },
                    { 101, 3 },
                    { 102, 3 },
                    { 103, 3 },
                    { 104, 3 },
                    { 105, 3 },
                    { 106, 3 },
                    { 107, 3 },
                    { 108, 3 },
                    { 109, 3 },
                    { 110, 3 },
                    { 111, 3 },
                    { 112, 3 },
                    { 113, 3 },
                    { 114, 3 },
                    { 115, 3 },
                    { 116, 3 },
                    { 118, 6 },
                    { 119, 6 },
                    { 120, 6 },
                    { 121, 6 },
                    { 122, 6 },
                    { 123, 6 },
                    { 124, 6 },
                    { 125, 6 },
                    { 126, 6 },
                    { 127, 6 },
                    { 128, 6 },
                    { 129, 6 },
                    { 130, 6 },
                    { 131, 6 }
                });

            migrationBuilder.InsertData(
                table: "CardFactions",
                columns: new[] { "CardId", "FactionId" },
                values: new object[,]
                {
                    { 132, 6 },
                    { 133, 6 },
                    { 134, 6 },
                    { 135, 6 },
                    { 136, 6 },
                    { 137, 6 },
                    { 138, 6 },
                    { 139, 6 },
                    { 140, 6 },
                    { 141, 6 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 2, 4, 1 },
                    { 3, 4, 1 },
                    { 4, 4, 1 },
                    { 4, 7, 1 },
                    { 5, 4, 2 },
                    { 6, 4, 3 },
                    { 7, 4, 1 },
                    { 7, 7, 2 },
                    { 8, 4, 2 },
                    { 8, 7, 1 },
                    { 9, 4, 2 },
                    { 9, 7, 1 },
                    { 10, 4, 1 },
                    { 10, 7, 3 },
                    { 11, 4, 1 },
                    { 11, 7, 3 },
                    { 12, 4, 2 },
                    { 12, 7, 2 },
                    { 13, 4, 3 },
                    { 13, 7, 2 },
                    { 14, 4, 1 },
                    { 14, 7, 1 },
                    { 15, 4, 2 },
                    { 15, 7, 1 },
                    { 16, 4, 1 },
                    { 16, 7, 1 },
                    { 17, 4, 1 },
                    { 18, 4, 1 },
                    { 19, 4, 2 },
                    { 19, 7, 1 },
                    { 20, 4, 2 },
                    { 20, 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 21, 4, 2 },
                    { 21, 7, 4 },
                    { 22, 4, 2 },
                    { 23, 4, 2 },
                    { 23, 7, 1 },
                    { 24, 5, 1 },
                    { 25, 5, 1 },
                    { 26, 5, 2 },
                    { 27, 5, 1 },
                    { 27, 7, 1 },
                    { 28, 5, 1 },
                    { 28, 7, 1 },
                    { 29, 5, 1 },
                    { 29, 7, 1 },
                    { 30, 5, 3 },
                    { 31, 5, 1 },
                    { 31, 7, 2 },
                    { 32, 5, 1 },
                    { 32, 7, 2 },
                    { 33, 5, 2 },
                    { 33, 7, 2 },
                    { 34, 5, 1 },
                    { 34, 7, 3 },
                    { 35, 5, 1 },
                    { 35, 7, 3 },
                    { 37, 5, 1 },
                    { 37, 7, 1 },
                    { 38, 5, 1 },
                    { 39, 5, 1 },
                    { 40, 5, 1 },
                    { 40, 7, 1 },
                    { 41, 5, 1 },
                    { 43, 5, 1 },
                    { 43, 7, 1 },
                    { 44, 5, 3 },
                    { 44, 7, 2 },
                    { 45, 5, 1 },
                    { 45, 7, 2 },
                    { 46, 5, 2 },
                    { 46, 7, 2 },
                    { 47, 1, 1 },
                    { 48, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 49, 1, 1 },
                    { 50, 1, 2 },
                    { 51, 1, 1 },
                    { 51, 7, 1 },
                    { 52, 1, 1 },
                    { 52, 7, 1 },
                    { 53, 1, 3 },
                    { 54, 1, 1 },
                    { 54, 7, 2 },
                    { 55, 1, 1 },
                    { 55, 7, 2 },
                    { 56, 1, 1 },
                    { 56, 7, 2 },
                    { 57, 1, 2 },
                    { 57, 7, 1 },
                    { 58, 1, 2 },
                    { 58, 7, 2 },
                    { 59, 1, 1 },
                    { 59, 7, 3 },
                    { 60, 1, 3 },
                    { 60, 7, 2 },
                    { 61, 1, 1 },
                    { 62, 1, 1 },
                    { 63, 1, 1 },
                    { 63, 7, 1 },
                    { 64, 1, 1 },
                    { 64, 7, 1 },
                    { 65, 1, 1 },
                    { 66, 1, 1 },
                    { 68, 1, 1 },
                    { 68, 7, 1 },
                    { 69, 1, 2 },
                    { 70, 2, 1 },
                    { 71, 2, 1 },
                    { 72, 2, 1 },
                    { 72, 7, 1 },
                    { 73, 2, 1 },
                    { 73, 7, 1 },
                    { 74, 2, 3 },
                    { 75, 2, 1 },
                    { 75, 7, 2 },
                    { 76, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 76, 7, 1 },
                    { 77, 2, 1 },
                    { 77, 7, 2 },
                    { 78, 2, 1 },
                    { 78, 7, 3 },
                    { 79, 2, 1 },
                    { 79, 7, 2 },
                    { 80, 2, 2 },
                    { 80, 7, 3 },
                    { 81, 2, 3 },
                    { 81, 7, 2 },
                    { 82, 2, 1 },
                    { 82, 7, 1 },
                    { 83, 2, 2 },
                    { 84, 2, 1 },
                    { 84, 7, 1 },
                    { 85, 2, 1 },
                    { 86, 2, 2 },
                    { 87, 2, 1 },
                    { 87, 7, 1 },
                    { 88, 2, 1 },
                    { 88, 7, 1 },
                    { 89, 2, 2 },
                    { 89, 7, 1 },
                    { 90, 2, 1 },
                    { 91, 2, 2 },
                    { 91, 7, 1 },
                    { 92, 2, 2 },
                    { 92, 7, 2 },
                    { 93, 2, 1 },
                    { 94, 3, 1 },
                    { 95, 3, 1 },
                    { 95, 7, 1 },
                    { 96, 3, 1 },
                    { 96, 7, 1 },
                    { 97, 3, 2 },
                    { 98, 3, 3 },
                    { 99, 3, 1 },
                    { 99, 7, 2 },
                    { 100, 3, 2 },
                    { 100, 7, 1 },
                    { 101, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 101, 7, 3 },
                    { 102, 3, 2 },
                    { 102, 7, 2 },
                    { 103, 3, 1 },
                    { 103, 7, 3 },
                    { 104, 3, 3 },
                    { 104, 7, 2 },
                    { 105, 3, 1 },
                    { 106, 3, 1 },
                    { 106, 7, 1 },
                    { 107, 3, 1 },
                    { 107, 7, 1 },
                    { 108, 3, 1 },
                    { 108, 7, 1 },
                    { 109, 3, 1 },
                    { 110, 3, 2 },
                    { 111, 3, 2 },
                    { 111, 7, 2 },
                    { 112, 3, 1 },
                    { 113, 3, 2 },
                    { 114, 3, 1 },
                    { 115, 3, 1 },
                    { 116, 3, 2 },
                    { 118, 6, 1 },
                    { 119, 6, 1 },
                    { 120, 6, 1 },
                    { 120, 7, 1 },
                    { 121, 6, 1 },
                    { 121, 7, 1 },
                    { 122, 6, 3 },
                    { 123, 6, 1 },
                    { 123, 7, 2 },
                    { 124, 6, 2 },
                    { 124, 7, 1 },
                    { 125, 6, 1 },
                    { 125, 7, 2 },
                    { 126, 6, 1 },
                    { 126, 7, 3 },
                    { 127, 6, 1 },
                    { 127, 7, 3 },
                    { 128, 6, 2 },
                    { 128, 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "CardResources",
                columns: new[] { "CardId", "ResourceId", "Quantity" },
                values: new object[,]
                {
                    { 129, 6, 2 },
                    { 129, 7, 2 },
                    { 130, 6, 3 },
                    { 130, 7, 2 },
                    { 131, 6, 1 },
                    { 131, 7, 1 },
                    { 132, 6, 2 },
                    { 132, 7, 1 },
                    { 133, 6, 1 },
                    { 134, 6, 1 },
                    { 135, 6, 1 },
                    { 135, 7, 1 },
                    { 136, 6, 1 },
                    { 136, 7, 1 },
                    { 137, 6, 2 },
                    { 138, 6, 1 },
                    { 139, 6, 2 },
                    { 139, 7, 2 },
                    { 140, 6, 1 },
                    { 140, 7, 1 },
                    { 141, 6, 1 },
                    { 141, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 2, 4, 1 },
                    { 3, 4, 1 },
                    { 4, 4, 1 },
                    { 4, 5, 1 },
                    { 5, 2, 1 },
                    { 5, 4, 1 },
                    { 6, 2, 1 },
                    { 6, 4, 2 },
                    { 7, 1, 1 },
                    { 7, 2, 1 },
                    { 7, 4, 1 },
                    { 8, 3, 1 },
                    { 8, 4, 1 },
                    { 8, 6, 1 },
                    { 9, 1, 1 },
                    { 9, 4, 1 },
                    { 9, 5, 1 },
                    { 10, 3, 1 },
                    { 10, 4, 2 },
                    { 10, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 11, 2, 1 },
                    { 11, 4, 2 },
                    { 11, 5, 1 },
                    { 12, 1, 1 },
                    { 12, 4, 2 },
                    { 12, 5, 1 },
                    { 13, 1, 1 },
                    { 13, 3, 1 },
                    { 13, 4, 3 },
                    { 24, 5, 1 },
                    { 25, 5, 1 },
                    { 26, 5, 1 },
                    { 26, 6, 1 },
                    { 27, 3, 1 },
                    { 27, 5, 1 },
                    { 28, 5, 1 },
                    { 29, 5, 1 },
                    { 30, 2, 1 },
                    { 30, 5, 2 },
                    { 31, 1, 1 },
                    { 31, 3, 1 },
                    { 31, 5, 1 },
                    { 32, 3, 1 },
                    { 32, 4, 1 },
                    { 32, 5, 1 },
                    { 33, 1, 1 },
                    { 33, 3, 1 },
                    { 33, 5, 1 },
                    { 34, 1, 1 },
                    { 34, 5, 2 },
                    { 35, 4, 1 },
                    { 35, 5, 2 },
                    { 35, 6, 1 },
                    { 47, 5, 1 },
                    { 48, 3, 1 },
                    { 49, 3, 1 },
                    { 50, 3, 1 },
                    { 50, 4, 1 },
                    { 51, 1, 1 },
                    { 51, 3, 1 },
                    { 52, 2, 1 },
                    { 52, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 53, 3, 2 },
                    { 53, 4, 1 },
                    { 54, 1, 1 },
                    { 54, 3, 2 },
                    { 54, 6, 1 },
                    { 56, 2, 1 },
                    { 56, 3, 1 },
                    { 56, 4, 1 },
                    { 57, 1, 1 },
                    { 57, 3, 1 },
                    { 57, 6, 1 },
                    { 58, 3, 2 },
                    { 58, 6, 1 },
                    { 59, 1, 1 },
                    { 59, 3, 2 },
                    { 59, 4, 1 },
                    { 60, 3, 3 },
                    { 60, 5, 1 },
                    { 60, 6, 1 },
                    { 70, 1, 1 },
                    { 71, 1, 1 },
                    { 71, 3, 1 },
                    { 72, 1, 1 },
                    { 72, 4, 1 },
                    { 73, 1, 1 },
                    { 73, 6, 1 },
                    { 74, 1, 2 },
                    { 74, 6, 1 },
                    { 75, 1, 1 },
                    { 75, 5, 1 },
                    { 75, 6, 1 },
                    { 76, 1, 1 },
                    { 76, 4, 1 },
                    { 76, 5, 1 },
                    { 77, 1, 1 },
                    { 77, 2, 1 },
                    { 77, 4, 1 },
                    { 78, 1, 2 },
                    { 78, 2, 1 },
                    { 78, 3, 1 },
                    { 79, 1, 1 },
                    { 79, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 79, 5, 1 },
                    { 80, 1, 3 },
                    { 80, 5, 1 },
                    { 81, 1, 3 },
                    { 81, 2, 1 },
                    { 81, 6, 1 },
                    { 94, 2, 1 },
                    { 95, 2, 1 },
                    { 96, 2, 1 },
                    { 97, 2, 1 },
                    { 97, 6, 1 },
                    { 98, 2, 2 },
                    { 98, 5, 1 },
                    { 99, 2, 1 },
                    { 99, 3, 1 },
                    { 101, 2, 2 },
                    { 101, 5, 1 },
                    { 103, 1, 1 },
                    { 103, 2, 1 },
                    { 103, 3, 1 },
                    { 104, 2, 3 },
                    { 104, 5, 3 },
                    { 104, 6, 3 },
                    { 118, 6, 1 },
                    { 119, 3, 1 },
                    { 120, 4, 1 },
                    { 120, 6, 1 },
                    { 121, 2, 1 },
                    { 121, 6, 1 },
                    { 122, 3, 1 },
                    { 122, 6, 2 },
                    { 123, 2, 1 },
                    { 123, 5, 1 },
                    { 123, 6, 1 },
                    { 124, 1, 1 },
                    { 124, 4, 1 },
                    { 124, 6, 1 },
                    { 125, 2, 1 },
                    { 125, 5, 1 },
                    { 125, 6, 1 },
                    { 126, 4, 1 },
                    { 126, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 127, 3, 1 },
                    { 127, 6, 2 },
                    { 128, 6, 1 },
                    { 129, 4, 1 },
                    { 129, 5, 1 },
                    { 129, 6, 2 },
                    { 130, 1, 1 },
                    { 130, 3, 1 },
                    { 130, 6, 3 },
                    { 142, 3, 2 },
                    { 142, 6, 2 },
                    { 142, 7, 3 },
                    { 143, 1, 2 },
                    { 143, 6, 2 },
                    { 143, 7, 3 },
                    { 144, 3, 2 },
                    { 144, 4, 2 },
                    { 144, 7, 3 },
                    { 145, 2, 2 },
                    { 145, 4, 2 },
                    { 145, 7, 3 },
                    { 146, 1, 2 },
                    { 146, 3, 2 },
                    { 146, 7, 3 },
                    { 147, 2, 2 },
                    { 147, 5, 2 },
                    { 147, 7, 3 },
                    { 148, 1, 3 },
                    { 148, 2, 3 },
                    { 148, 7, 4 },
                    { 149, 4, 3 },
                    { 149, 6, 3 },
                    { 149, 7, 4 },
                    { 150, 2, 3 },
                    { 150, 4, 3 },
                    { 150, 7, 4 },
                    { 151, 1, 3 },
                    { 151, 5, 3 },
                    { 151, 7, 4 },
                    { 152, 3, 3 },
                    { 152, 5, 3 },
                    { 152, 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "CardTalents",
                columns: new[] { "CardId", "TalentId", "Quantity" },
                values: new object[,]
                {
                    { 153, 3, 3 },
                    { 153, 6, 3 },
                    { 153, 7, 4 },
                    { 154, 1, 3 },
                    { 154, 6, 3 },
                    { 154, 7, 4 },
                    { 155, 3, 4 },
                    { 155, 5, 4 },
                    { 155, 7, 5 },
                    { 156, 1, 4 },
                    { 156, 2, 4 },
                    { 156, 7, 5 },
                    { 157, 2, 4 },
                    { 157, 6, 4 },
                    { 157, 7, 5 },
                    { 158, 5, 4 },
                    { 158, 6, 4 },
                    { 158, 7, 5 },
                    { 160, 7, 2 },
                    { 161, 7, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 46, 5 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 96, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 98, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 99, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 101, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 102, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 103, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 104, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 105, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 106, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 107, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 108, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 109, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 110, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 111, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 113, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 114, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 115, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 116, 3 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 119, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 120, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 122, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 123, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 124, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 125, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 126, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 127, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 128, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 129, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 130, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 131, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 132, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 133, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 134, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 135, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 136, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 137, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 138, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 139, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 140, 6 });

            migrationBuilder.DeleteData(
                table: "CardFactions",
                keyColumns: new[] { "CardId", "FactionId" },
                keyValues: new object[] { 141, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 40, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 44, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 45, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 46, 5 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 46, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 52, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 55, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 56, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 58, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 59, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 60, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 63, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 64, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 68, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 73, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 75, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 76, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 77, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 78, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 79, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 80, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 81, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 82, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 84, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 87, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 88, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 89, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 91, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 92, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 95, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 96, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 96, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 98, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 99, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 99, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 100, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 101, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 101, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 102, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 102, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 103, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 103, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 104, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 104, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 105, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 106, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 106, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 107, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 107, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 108, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 108, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 109, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 110, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 111, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 111, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 113, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 114, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 115, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 116, 3 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 119, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 120, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 120, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 121, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 122, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 123, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 123, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 124, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 124, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 125, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 125, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 126, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 126, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 127, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 127, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 128, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 128, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 129, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 129, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 130, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 130, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 131, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 131, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 132, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 132, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 133, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 134, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 135, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 135, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 136, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 136, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 137, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 138, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 139, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 139, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 140, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 140, 7 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 141, 6 });

            migrationBuilder.DeleteData(
                table: "CardResources",
                keyColumns: new[] { "CardId", "ResourceId" },
                keyValues: new object[] { 141, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 47, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 48, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 50, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 50, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 51, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 52, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 53, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 54, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 56, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 56, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 57, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 57, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 58, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 58, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 59, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 59, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 60, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 60, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 60, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 71, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 72, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 73, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 74, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 75, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 75, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 76, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 76, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 77, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 79, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 80, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 81, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 97, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 99, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 99, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 101, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 101, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 103, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 103, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 103, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 104, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 119, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 120, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 120, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 121, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 122, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 122, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 123, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 123, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 123, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 124, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 124, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 124, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 125, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 125, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 125, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 126, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 126, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 127, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 127, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 128, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 129, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 129, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 129, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 130, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 130, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 130, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 142, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 142, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 142, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 143, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 143, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 143, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 144, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 144, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 144, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 145, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 145, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 145, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 146, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 146, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 146, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 147, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 147, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 147, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 148, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 148, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 148, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 149, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 149, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 149, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 150, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 150, 4 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 150, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 151, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 151, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 151, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 152, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 152, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 152, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 153, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 153, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 153, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 154, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 154, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 154, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 155, 3 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 155, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 155, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 156, 1 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 156, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 156, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 157, 2 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 157, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 157, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 158, 5 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 158, 6 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 158, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 160, 7 });

            migrationBuilder.DeleteData(
                table: "CardTalents",
                keyColumns: new[] { "CardId", "TalentId" },
                keyValues: new object[] { 161, 7 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "ChemicalWarfare");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Yellow");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Blue");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Red");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Green");

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Purple");
        }
    }
}
