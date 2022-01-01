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
                       +"then move that Agent to the Shuttle area.",
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

                new Card
                {
                    Id = (int)Enum.CardId.ChemicalWarfare,
                    Name = "ChemicalWarfare",
                    Unique = false,
                    Type = (int)Enum.CardType.Maneuver,
                    Ability = "Deal 1 damage to each Agent on a Mission.",
                    ExpansionId = (int)Enum.Expansion.SoItBegins,
                    ExpansionSerialNumber = "067"
                },
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
            );
        }
    }
}