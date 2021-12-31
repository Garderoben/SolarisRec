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