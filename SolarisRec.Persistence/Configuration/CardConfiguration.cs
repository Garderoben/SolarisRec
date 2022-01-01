using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;
using System;
using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.Persistence.Configuration
{
    internal class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Cards");

            builder.Property(c => c.Name)
                .IsRequired(true);

            builder.Property(c => c.Name)
                .HasMaxLength(48);

            builder.Property(c => c.Ability)
                .IsRequired(false);

            builder.Property(c => c.Type)
                .IsRequired(true);

            builder.Property(c => c.AttackValue)
                .IsRequired(false);

            builder.Property(c => c.HealthValue)
                .IsRequired(false);

            builder.Property(c => c.ExpansionSerialNumber)
                .IsRequired(true);

            builder.Property(c => c.ExpansionSerialNumber).HasColumnType("VARCHAR").HasMaxLength(4);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<Card> builder)
        {
            builder.HasData
            (

            #region Belt

                new Card
                {
                    Id = (int)Enum.CardId.Turncoat,
                    Name = "Turncoat",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 2,
                    Ability = "Forced Reaction: When thisAgent enters play, put 2 traitor counters on it."
                        + Environment.NewLine
                        + "Forced Reaction: When this Agent would leave play, instead remove 1 traitor counter from this Agent,"
                        + Environment.NewLine
                        + "heal all of its damage and your opponent takes control of it."
                    ,
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "001"
                },
                new Card
                {
                    Id = (int)Enum.CardId.InsuredColleague,
                    Name = "Insured Colleague",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 1,
                    HealthValue = 1,
                    Ability = "Reaction: After this Agent leaves play, draw 1 card.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "002"
                },
                new Card
                {
                    Id = (int)Enum.CardId.BeggarInformator,
                    Name = "Beggar Informator",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 0,
                    HealthValue = 1,
                    Ability = "Reaction: After this Agent leaves play, look at the top 2 cards of your deck,"
                        + Environment.NewLine
                        + "put one of them into your hand and the other to the bottom of your deck.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "003"
                },
                new Card
                {
                    Id = (int)Enum.CardId.KoronisBelter,
                    Name = "Koronis Belter",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 2,
                    Ability = "Reaction, [B][B][A2]: After this Agent deals attack damage to an Agent, destroy that Agent.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "004"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Concubine,
                    Name = "Concubine",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 2,
                    Ability = "Sacrifice: Target Agent loses a Talent of your choice on this Mission until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "005"
                },
                new Card
                {
                    Id = (int)Enum.CardId.MadameKyung,
                    Name = "Madame Kyung",
                    Unique = true,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 4,
                    Ability = "Use, Sacrifice an Agent on this Mission: Target opponent sacrifices an Agent on this Mission,"
                        + Environment.NewLine
                        + "then you draw 1 Card",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "006"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Phisher,
                    Name = "Phisher",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 3,
                    Ability = "[B][A2]: This Agent gains [Data] or [Mining] until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "007"
                },
                new Card
                {
                    Id = (int)Enum.CardId.VestaExtortionist,
                    Name = "Vesta Extortionist",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 3,
                    HealthValue = 1,
                    Ability = "Reaction: Cancel the first attack targeting this Agent in the Conflict phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "008"
                },
                new Card
                {
                    Id = (int)Enum.CardId.YoungScum,
                    Name = "Young Scum",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 1,
                    HealthValue = 1,
                    Ability = "Reaction: After this Agent leaves play, put a 2/2 Scum Agent token"
                        + Environment.NewLine
                        + "with [Espionage] into play on the same Area.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "009"
                },
                new Card
                {
                    Id = (int)Enum.CardId.VestaThug,
                    Name = "Vesta Thug",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 4,
                    HealthValue = 3,
                    Ability = "[B][B][A3], Use: Put a 2/2 Scum Agent token with [Espionage] into play"
                        + Environment.NewLine
                        + "on the same Area.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "010"
                },
                new Card
                {
                    Id = (int)Enum.CardId.RebelSaboteur,
                    Name = "Rebel Saboteur",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 3,
                    HealthValue = 4,
                    Ability = "Sacrifice: Destroy target Construction",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "011"
                },
                new Card
                {
                    Id = (int)Enum.CardId.GangLeader,
                    Name = "Gang Leader",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 4,
                    Ability = "Conflict action, Use: Target enemy Agent"
                       + Environment.NewLine
                       + "on this Mission moves to another Ready"
                       + Environment.NewLine
                       + "Mission, if there are no Ready Missions,"
                       + Environment.NewLine
                       + "then move that Agent to the Shuttle area.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "012"
                },
                new Card
                {
                    Id = (int)Enum.CardId.MrYue,
                    Name = "Mr. Yué",
                    Unique = true,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 3,
                    HealthValue = 4,
                    Ability = "Reaction: After a friendly"
                       + Environment.NewLine
                       + "non-token Agent leaves play,"
                       + Environment.NewLine
                       + "put 1 Influence on this Agent.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "013"
                },
                new Card
                {
                    Id = (int)Enum.CardId.GrowingInfection,
                    Name = "Growing Infection",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "When you play this card, attach it to an Agent and"
                       + Environment.NewLine
                       + "put 1 infection counter on this card."
                       + Environment.NewLine
                       + "Reaction: At the beginning of the Starting phase put"
                       + Environment.NewLine
                       + "1 infection counter on this card. If there are equal or"
                       + Environment.NewLine
                       + "more infection counters on this card as the"
                       + Environment.NewLine
                       + "converted Resource cost of the attached Agent,"
                       + Environment.NewLine
                       + "destroy that Agent.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "014"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Execution,
                    Name = "Execution",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Syndicate Maneuver"
                       + Environment.NewLine
                       + "Destroy target Agent.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "015"
                },
                new Card
                {
                    Id = (int)Enum.CardId.HuntDown,
                    Name = "Hunt Down",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Reaction: After an Agent you control"
                       + Environment.NewLine
                       + "deals attack damage to a non-Unique"
                       + Environment.NewLine
                       + "Agent, destroy that Agent.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "016"
                },
                new Card
                {
                    Id = (int)Enum.CardId.OrganDonor,
                    Name = "Organ Donor",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Sacrifice an Agent: Prevent all damage"
                       + Environment.NewLine
                       + "from one source to an Agent on the"
                       + Environment.NewLine
                       + "same Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "017"
                },
                new Card
                {
                    Id = (int)Enum.CardId.YouareTired,
                    Name = "You are Tired!",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Move target used enemy Agent to a Ready"
                       + Environment.NewLine
                       + "Mission, if there are no Ready Missions, then"
                       + Environment.NewLine
                       + "move that Agent to the Shuttle area.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "018"
                },
                new Card
                {
                    Id = (int)Enum.CardId.EyeforanEye,
                    Name = "Eye for an Eye",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Syndicate Maneuver"
                       + Environment.NewLine
                       + "All players destroy 1 Agent"
                       + Environment.NewLine
                       + "in all their Shuttles.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "019"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Arson,
                    Name = "Arson",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Syndicate Maneuver"
                       + Environment.NewLine
                       + "Sacrifice an Agent: Destroy target"
                       + Environment.NewLine
                       + "Agent or Construction.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "020"
                },
                new Card
                {
                    Id = (int)Enum.CardId.BestoftheBelt,
                    Name = "Best of the Belt",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Syndicate Maneuver"
                       + Environment.NewLine
                       + "Put three 2/2 Scum Agent tokens"
                       + Environment.NewLine
                       + "with [Espionage] into a Shuttle.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "021"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Donorcenter,
                    Name = "Donor center",
                    Unique = true,
                    Type = (int)Enum.CardType.Construction,
                    Ability = "Use, Sacrifice a non-token Agent:"
                       + Environment.NewLine
                       + "Draw 1 card.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "022"
                },
                new Card
                {
                    Id = (int)Enum.CardId.AsteroidIntelStation,
                    Name = "Asteroid Intel Station",
                    Unique = false,
                    Type = (int)Enum.CardType.Construction,
                    Ability = "Use: Use target Agent"
                       + Environment.NewLine
                       + "unless its controller pays [A2].",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "023"
                },

            #endregion

            #region Earth

                 new Card
                 {
                     Id = (int)Enum.CardId.AcolyteinTraining,
                     Name = "Acolyte in Training",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 0,
                     HealthValue = 1,
                     Ability = "Syndicate action, Use, Discard a"
                        + Environment.NewLine
                        + "card: Put a +1/+1 counter on this"
                        + Environment.NewLine
                        + "Agent",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "024"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.MonkofSol,
                     Name = "Monk of Sol",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 1,
                     HealthValue = 1,
                     Ability = "Reaction: After this Agent leaves"
                        + Environment.NewLine
                        + "play, put a +1/+1 counter on target"
                        + Environment.NewLine
                        + "Agent on the same area.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "025"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.SanctionedPriest,
                     Name = "Sanctioned Priest",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 1,
                     HealthValue = 2,
                     Ability = "Reaction: After this Agent enters"
                        + Environment.NewLine
                        + "play draw 1 card.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "026"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.EarthseedActivist,
                     Name = "Earthseed Activist",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 2,
                     HealthValue = 2,
                     Ability = "[E][E][A1]: Increase a Talent"
                       + Environment.NewLine
                       + "requirement on this Mission by 1"
                       + Environment.NewLine
                       + "until the end of the phase.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "027"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.PeacefulRepresentative,
                     Name = "Peaceful Representative",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 1,
                     HealthValue = 1,
                     Ability = "Reaction: After this Agent enters play"
                       + Environment.NewLine
                       + "put the top card of your deck under it"
                       + Environment.NewLine
                       + "face down. At the beginning of the"
                       + Environment.NewLine
                       + "Starting phase, draw that card.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "028"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.ReveredMediator,
                     Name = "Revered Mediator",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 0,
                     HealthValue = 2,
                     Ability = "Conflict action, Use: Move this Agent"
                       + Environment.NewLine
                       + "and a non-Unique enemy Agent on this"
                       + Environment.NewLine
                       + "Mission with converted Resource cost 3"
                       + Environment.NewLine
                       + "or lower to the Shuttle area.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "029"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.NegotiatorEld,
                     Name = "Negotiator Eld",
                     Unique = true,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 3,
                     HealthValue = 3,
                     Ability = "Reaction: After this Agent"
                       + Environment.NewLine
                       + "completes a Mission, draw 1 card.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "030"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.ExiledPaladin,
                     Name = "Exiled Paladin",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 2,
                     HealthValue = 3,
                     Ability = "While this Agent is ready, it takes 1"
                       + Environment.NewLine
                       + "less damage from any source.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "031"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.InvestigatorPaladin,
                     Name = "Investigator Paladin",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 3,
                     HealthValue = 2,
                     Ability = "Reaction: After this Agent enters play"
                       + Environment.NewLine
                       + "put the top card of your deck under it"
                       + Environment.NewLine
                       + "face down. At the beginning of the"
                       + Environment.NewLine
                       + "Starting phase, draw that card.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "032"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.GuardianPaladin,
                     Name = "Guardian Paladin",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 1,
                     HealthValue = 6,
                     Ability = "Reaction: After another Agent is"
                       + Environment.NewLine
                       + "assigned attack damage on this Mission"
                       + Environment.NewLine
                       + "you may reassign it to this Agent.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "033"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.PoliticalAdvisor,
                     Name = "Political Advisor",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 4,
                     HealthValue = 3,
                     Ability = "Reaction: After this Agent"
                       + Environment.NewLine
                       + "completes a Mission gain 1"
                       + Environment.NewLine
                       + "Influence.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "034"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.CosmicLinkManager,
                     Name = "CosmicLink Manager",
                     Unique = false,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 3,
                     HealthValue = 4,
                     Ability = "[E][E][A2]: Target Agent on a ready"
                       + Environment.NewLine
                       + "Mission gains a Talent of your"
                       + Environment.NewLine
                       + "choice until the end of the phase.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "035"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.AmbassadorSunders,
                     Name = "Ambassador Sunders",
                     Unique = true,
                     Type = (int)Enum.CardType.Agent,
                     AttackValue = 0,
                     HealthValue = 5,
                     Ability = "This Agent cannot be targeted by Conflict"
                       + Environment.NewLine
                       + "actions if there are any other friendly Agents on"
                       + Environment.NewLine
                       + "this Mission."
                       + Environment.NewLine
                       + "Conflict Action, Use: Return target non-Unique"
                       + Environment.NewLine
                       + "enemy Agent on this Mission to its owners hand.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "036"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.HeroicRescue,
                     Name = "Heroic Rescue",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Reaction: After an attack is declared"
                       + Environment.NewLine
                       + "against an Agent you control, choose a"
                       + Environment.NewLine
                       + "new defender.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "037"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.SawitComing,
                     Name = "Saw it Coming",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Reaction: Prevent all damage on an"
                       + Environment.NewLine
                       + "Agent from a source that deals 3 or"
                       + Environment.NewLine
                       + "more damage.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "038"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.ExpendableBodyguard,
                     Name = "Expendable Bodyguard",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Reaction: Prevent 2 damage",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "039"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.IntroducingtoTheFaith,
                     Name = "Introducing to The Faith",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Return target non-Unique Agent with"
                       + Environment.NewLine
                       + "converted Resource cost 3 or lower to its"
                       + Environment.NewLine
                       + "owners hand.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "040"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.CantTouchMe,
                     Name = "Can't Touch Me",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Conflict action, Use target Agent:"
                       + Environment.NewLine
                       + "Move target friendly Agent and a"
                       + Environment.NewLine
                       + "non-Unique enemy Agent on the same"
                       + Environment.NewLine
                       + "Mission with converted Resource cost 3 or"
                       + Environment.NewLine
                       + "lower to the Shuttle area.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "041"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.HardTimes,
                     Name = "Hard Times",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Attach this card to a Mission. Increase all"
                       + Environment.NewLine
                       + "Talent requirements on this Mission by 1."
                       + Environment.NewLine
                       + "Forced Reaction: After completing this"
                       + Environment.NewLine
                       + "Mission, destroy this card.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "042"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.TwistofFate,
                     Name = "Twist of Fate",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Change a Talent requirement on a"
                       + Environment.NewLine
                       + "Mission until the end of round.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "043"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.ScorchedEarthTactic,
                     Name = "Scorched Earth Tactic",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Destroy all Agents"
                       + Environment.NewLine
                       + "on target Mission.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "044"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.PoliticalDelegation,
                     Name = "Political Delegation",
                     Unique = false,
                     Type = (int)Enum.CardType.Maneuver,
                     Ability = "Choose up to 3 Agents,"
                       + Environment.NewLine
                       + "they gain [Diplomacy] until the"
                       + Environment.NewLine
                       + "end of the phase.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "045"
                 },
                 new Card
                 {
                     Id = (int)Enum.CardId.PoliticalAcademy,
                     Name = "Political Academy",
                     Unique = false,
                     Type = (int)Enum.CardType.Construction,
                     Ability = "Preparing."
                       + Environment.NewLine
                       + "[This card enters play Used.]"
                       + Environment.NewLine
                       + "Syndicate action, Use:"
                       + Environment.NewLine
                       + "Put an 1/1 Envoy Agent token"
                       + Environment.NewLine
                       + "with [Diplomacy] into play.",
                     ExpansionId = (int)Enum.Expansion.SoItBegins,
                     ExpansionSerialNumber = "046"
                 },

            #endregion

            #region Mars
                
                new Card
                {
                    Id = (int)Enum.CardId.MartianDiplomat,
                    Name = "Martian Diplomat",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 0,
                    HealthValue = 2,
                    Ability = "Use: Choose a Talent on another Agent"
                        + Environment.NewLine
                        + "on this Mission, give that Agent on more"
                        + Environment.NewLine
                        + "of that Talent until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "047"
                },
                new Card
                {
                    Id = (int)Enum.CardId.CrimsonGrenadier,
                    Name = "Crimson Grenadier",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 1,
                    HealthValue = 1,
                    Ability = "Reaction: After this Agent leaves"
                        + Environment.NewLine
                        + "play, each player deals 1 damage"
                        + Environment.NewLine
                        + "to target enemy Agent on this"
                        + Environment.NewLine
                        + "Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "048"
                },
                new Card
                {
                    Id = (int)Enum.CardId.CrimsonLegionInfantry,
                    Name = "Crimson Legion Infantry",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 1,
                    HealthValue = 1,
                    Ability = "Reaction: After this Agent leaves play,"
                        + Environment.NewLine
                        + "search your deck for a card named"
                        + Environment.NewLine
                        + "Crimson Legion Infantry, reveal it and"
                        + Environment.NewLine
                        + "add it to your hand. Shuffle.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "049"
                },
                new Card
                {
                    Id = (int)Enum.CardId.SpecialOps,
                    Name = "Special Ops",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 1,
                    Ability = "Reaction, [Ma]: After this Agent is"
                        + Environment.NewLine
                        + "deployed to a Mission, search your deck"
                        + Environment.NewLine
                        + "or hand for a card named Special Ops,"
                        + Environment.NewLine
                        + "put it into play on this Mission Used."
                        + Environment.NewLine
                        + "Shuffle."
                        + Environment.NewLine
                        + "[Limit once per phase.]",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "050"
                },
                new Card
                {
                    Id = (int)Enum.CardId.CrimsonShockTroops,
                    Name = "Crimson Shock Troops",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 2,
                    Ability = "[Ma][A1]: This Agent gains"
                        + Environment.NewLine
                        + "+1/+0 until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "051"
                },
                new Card
                {
                    Id = (int)Enum.CardId.CrimsonLegionScout,
                    Name = "Crimson Legion Scout",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 1,
                    Ability = "Reaction: After this Agent leaves play,"
                        + Environment.NewLine
                        + "target Agent gains a Talent of your"
                        + Environment.NewLine
                        + "choice until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "052"
                },
                new Card
                {
                    Id = (int)Enum.CardId.SergeantJoseph,
                    Name = "Sergeant Joseph",
                    Unique = true,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 3,
                    HealthValue = 3,
                    Ability = "Reaction: After this Agent deals"
                        + Environment.NewLine
                        + "attack damage to an enemy Agent,"
                        + Environment.NewLine
                        + "deal 1 damage to target Agent on"
                        + Environment.NewLine
                        + "this Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "053"
                },
                new Card
                {
                    Id = (int)Enum.CardId.ChefuMilitia,
                    Name = "Chefu Militia",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 2,
                    Ability = "[Ma][Ma][A1]: Deal 1 damage"
                        + Environment.NewLine
                        + "to target Agent on this Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "054"
                },
                new Card
                {
                    Id = (int)Enum.CardId.TarakanGuard,
                    Name = "Tarakan Guard",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 3,
                    HealthValue = 2,
                    Ability = "[Ma][Ma]: This Agent gains [Military]"
                        + Environment.NewLine
                        + "until the end of this phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "055"
                },
                new Card
                {
                    Id = (int)Enum.CardId.ChameleonCorps,
                    Name = "Chameleon Corps",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 3,
                    Ability = "[A2]: This Agent gains a Talent of"
                        + Environment.NewLine
                        + "your choice until the end"
                        + Environment.NewLine
                        + "of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "056"
                },
                new Card
                {
                    Id = (int)Enum.CardId.ExplosiveExpert,
                    Name = "Explosive Expert",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 2,
                    HealthValue = 2,
                    Ability = "Reaction: After this Agent is deployed"
                        + Environment.NewLine
                        + "to a Mission, deal 1 damage to each"
                        + Environment.NewLine
                        + "enemy Agent on this Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "057"
                },
                new Card
                {
                    Id = (int)Enum.CardId.SupplyLineOfficer,
                    Name = "Supply Line Officer",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 4,
                    HealthValue = 3,
                    Ability = "Reaction: After this Agent is deployed"
                        + Environment.NewLine
                        + "to a Mission, look at the top 3 cards of"
                        + Environment.NewLine
                        + "your deck, you may reveal an Agent"
                        + Environment.NewLine
                        + "card and add it to your hand. Shuffle.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "058"
                },
                new Card
                {
                    Id = (int)Enum.CardId.IrharenVeteran,
                    Name = "Irharen Veteran",
                    Unique = false,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 4,
                    HealthValue = 3,
                    Ability = "[Ma][Ma][A2]: Deal 2 damage"
                        + Environment.NewLine
                        + "to target agent on this Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "059"
                },
                new Card
                {
                    Id = (int)Enum.CardId.GeneralRwanda,
                    Name = "General Rwanda",
                    Unique = true,
                    Type = (int)Enum.CardType.Agent,
                    AttackValue = 3,
                    HealthValue = 6,
                    Ability = "Reaction: After this Agent is deployed to"
                        + Environment.NewLine
                        + "a Mission, put a 1/1 Infantry Agent token"
                        + Environment.NewLine
                        + "with [Military] into play on this Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "060"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Headshot,
                    Name = "Headshot",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Hasty"
                        + Environment.NewLine
                        + "[If you play this card during the"
                        + Environment.NewLine
                        + "Conflict phase, pay [A1] more.]"
                        + Environment.NewLine
                        + "Deal 2 damage to target Agent.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "061"
                },
                new Card
                {
                    Id = (int)Enum.CardId.PreparedAmbush,
                    Name = "Prepared Ambush",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Conflict Maneuver"
                        + Environment.NewLine
                        + "Use an Agent: Deal its attack value to"
                        + Environment.NewLine
                        + "target Agent on the same mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "062"
                },
                new Card
                {
                    Id = (int)Enum.CardId.UnexpectedCourage,
                    Name = "Unexpected Courage",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Conflict Maneuver"
                        + Environment.NewLine
                        + "Target friendly Agent deals its attack value to"
                        + Environment.NewLine
                        + "target Agent on the same mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "063"
                },
                new Card
                {
                    Id = (int)Enum.CardId.DevotedLearning,
                    Name = "Devoted Learning",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Reaction: After completing a Mission,"
                        + Environment.NewLine
                        + "draw 3 cards."
                        + Environment.NewLine
                        + "[Limit once per mission.]",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "064"
                },
                new Card
                {
                    Id = (int)Enum.CardId.MartianEducation,
                    Name = "Martian Education",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Target Agent gains a Talent of your"
                        + Environment.NewLine
                        + "choice until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "065"
                },
                new Card
                {
                    Id = (int)Enum.CardId.Aftermath,
                    Name = "Aftermath",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Reaction: After completing a Mission,"
                        + Environment.NewLine
                        + "deal 3 damage to target Agent in play.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "066"
                },
                new Card
                {
                    Id = (int)Enum.CardId.ChemicalWarfare,
                    Name = "Chemical Warfare",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Deal 1 damage to each Agent on a Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "067"
                },
                new Card
                {
                    Id = (int)Enum.CardId.WarPropaganda,
                    Name = "War Propaganda",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Reaction: After you claim a Mission,"
                        + Environment.NewLine
                        + "instead of your opponent, you put the new"
                        + Environment.NewLine
                        + "Mission from your Mission Deck into play.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "068"
                },
                new Card
                {
                    Id = (int)Enum.CardId.OlympusUniversity,
                    Name = "Olympus University",
                    Unique = true,
                    Type = (int)Enum.CardType.Construction,
                    Ability = "Use: Target Agent gains a"
                        + Environment.NewLine
                        + "Talent of your choice"
                        + Environment.NewLine
                        + "until the end of the phase.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "069"
                },

            #endregion

            #region Mercury

                //new Card
                //{
                //    Id = (int)Enum.CardId.MartianDiplomat,
                //    Name = "Martian Diplomat",
                //    Unique = false,
                //    Type = (int)Enum.CardType.Agent,
                //    AttackValue = 0,
                //    HealthValue = 2,
                //    Ability = "Use: Choose a Talent on another Agent"
                //        + Environment.NewLine
                //        + "on this Mission, give that Agent on more"
                //        + Environment.NewLine
                //        + "of that Talent until the end of the phase.",
                //    ExpansionId = (int)Enum.Expansion.SoItBegins,
                //    ExpansionSerialNumber = "047"
                //},

            #endregion

            #region Titan

                new Card
                {
                    Id = (int)Enum.CardId.CyberBankOfTitan,
                    Name = "Cyber Bank of Titan",
                    Unique = true,
                    Type = (int)Enum.CardType.Construction,
                    Ability = "Forced Reaction: After this card enters play put the top 5 cards of your deck under it face down"
                        + Environment.NewLine
                        + "[You may look at these cards any time.]"
                        + Environment.NewLine
                        + "Use: Play a card from under this card. When there are no cards left under this card, destroy it.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "117"
                },

            #endregion

            #region Venus



            #endregion

            #region Mission

                new Card
                {
                    Id = (int)Enum.CardId.Redistribution,
                    Name = "Redistribution",
                    Unique = false,
                    Type = (int)Enum.CardType.Mission,
                    Ability = "Discard your hand then draw 5 cards.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "159"
                }

                #endregion

            );
        }
    }
}