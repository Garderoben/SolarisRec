using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.Persistence.Configuration.JoiningTables
{
    internal class CardFactionConfiguration : IEntityTypeConfiguration<CardFaction>
    {
        public void Configure(EntityTypeBuilder<CardFaction> builder)
        {
            builder.ToTable("CardFactions");

            builder.HasKey(cf => new { cf.CardId, cf.FactionId });

            builder.HasOne(cf => cf.Card)
                .WithMany(c => c.CardFactions)
                .HasForeignKey(cf => cf.CardId);

            builder.HasOne(cf => cf.Faction)
                .WithMany(r => r.CardFactions)
                .HasForeignKey(cf => cf.FactionId);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<CardFaction> builder)
        {
            builder.HasData
            (                
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Turncoat,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CyberBankOfTitan,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ChemicalWarfare,
                    FactionId = (int)Enum.Faction.Mars
                }
            );
        }
    }
}