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
                #region Belt

                new CardFaction
                {
                    CardId = (int)Enum.CardId.Turncoat,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.InsuredColleague,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.BeggarInformator,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.KoronisBelter,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Concubine,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MadameKyung,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Phisher,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.VestaExtortionist,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.YoungScum,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.VestaThug,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.RebelSaboteur,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.GangLeader,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MrYue,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.GrowingInfection,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Execution,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.HuntDown,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.OrganDonor,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.YouareTired,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.EyeforanEye,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Arson,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.BestoftheBelt,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Donorcenter,
                    FactionId = (int)Enum.Faction.Belt
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.AsteroidIntelStation,
                    FactionId = (int)Enum.Faction.Belt
                },

                #endregion

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