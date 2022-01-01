﻿using Microsoft.EntityFrameworkCore;
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

            #region Earth

                new CardFaction
                {
                    CardId = (int)Enum.CardId.AcolyteinTraining,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MonkofSol,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SanctionedPriest,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.EarthseedActivist,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.PeacefulRepresentative,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ReveredMediator,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.NegotiatorEld,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ExiledPaladin,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.InvestigatorPaladin,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.GuardianPaladin,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.PoliticalAdvisor,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CosmicLinkManager,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.HeroicRescue,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SawitComing,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ExpendableBodyguard,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.IntroducingtoTheFaith,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CantTouchMe,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.TwistofFate,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ScorchedEarthTactic,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.PoliticalDelegation,
                    FactionId = (int)Enum.Faction.Earth
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.PoliticalAcademy,
                    FactionId = (int)Enum.Faction.Earth
                },

            #endregion

            #region Mars

                new CardFaction
                {
                    CardId = (int)Enum.CardId.ChemicalWarfare,
                    FactionId = (int)Enum.Faction.Mars
                },

            #endregion

                #region Mercury



                #endregion

                #region Titan

                new CardFaction
                {
                    CardId = (int)Enum.CardId.CyberBankOfTitan,
                    FactionId = (int)Enum.Faction.Titan
                }

            #endregion

            #region Venus



            #endregion

            #region Mission



            #endregion
                
            );
        }
    }
}