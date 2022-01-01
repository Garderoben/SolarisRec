using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.Persistence.Configuration.JoiningTables
{
    internal class CardTalentConfiguration : IEntityTypeConfiguration<CardTalent>
    {
        public void Configure(EntityTypeBuilder<CardTalent> builder)
        {
            builder.ToTable("CardTalents");

            builder.HasKey(ct => new { ct.CardId, ct.TalentId });

            builder.HasOne(ct => ct.Card)
                .WithMany(c => c.CardTalents)
                .HasForeignKey(ct => ct.CardId);

            builder.HasOne(ct => ct.Talent)
                .WithMany(t => t.CardTalents)
                .HasForeignKey(ct => ct.TalentId);

            builder.Property(ct => ct.Quantity)
                .IsRequired(true);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<CardTalent> builder)
        {
            builder.HasData
            (

            #region Belt

                new CardTalent
                {
                    CardId = (int)Enum.CardId.Turncoat,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.InsuredColleague,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BeggarInformator,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.KoronisBelter,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.KoronisBelter,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Concubine,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Concubine,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MadameKyung,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MadameKyung,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Phisher,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Phisher,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Phisher,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.VestaExtortionist,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.VestaExtortionist,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.VestaExtortionist,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.YoungScum,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.YoungScum,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.YoungScum,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.VestaThug,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.VestaThug,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.VestaThug,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.RebelSaboteur,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.RebelSaboteur,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.RebelSaboteur,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GangLeader,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GangLeader,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GangLeader,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MrYue,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 3
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MrYue,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MrYue,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },

            #endregion

            #region Earth

                new CardTalent
                {
                    CardId = (int)Enum.CardId.AcolyteinTraining,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MonkofSol,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SanctionedPriest,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SanctionedPriest,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.EarthseedActivist,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.EarthseedActivist,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.PeacefulRepresentative,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ReveredMediator,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NegotiatorEld,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NegotiatorEld,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ExiledPaladin,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ExiledPaladin,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ExiledPaladin,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.InvestigatorPaladin,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.InvestigatorPaladin,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.InvestigatorPaladin,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GuardianPaladin,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GuardianPaladin,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GuardianPaladin,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.PoliticalAdvisor,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.PoliticalAdvisor,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CosmicLinkManager,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CosmicLinkManager,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CosmicLinkManager,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                

            #endregion

            #region Mars



            #endregion

            #region Mercury



            #endregion

            #region Titan



            #endregion

            #region Venus



            #endregion

            #region Mission

                new CardTalent
                {
                    CardId = (int)Enum.CardId.Redistribution,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 4
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Redistribution,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 4
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Redistribution,
                    TalentId = (int)Enum.Talent.Any,
                    Quantity = 5
                }

                #endregion

            );
        }
    }
}