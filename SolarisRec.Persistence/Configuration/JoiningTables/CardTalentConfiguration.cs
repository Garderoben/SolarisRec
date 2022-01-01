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

                new CardTalent
                {
                    CardId = (int)Enum.CardId.MartianDiplomat,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CrimsonGrenadier,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CrimsonLegionInfantry,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SpecialOps,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SpecialOps,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CrimsonShockTroops,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CrimsonShockTroops,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CrimsonLegionScout,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CrimsonLegionScout,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SergeantJoseph,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SergeantJoseph,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ChefuMilitia,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ChefuMilitia,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ChefuMilitia,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ChameleonCorps,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ChameleonCorps,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ChameleonCorps,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ExplosiveExpert,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ExplosiveExpert,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ExplosiveExpert,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SupplyLineOfficer,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SupplyLineOfficer,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.IrharenVeteran,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.IrharenVeteran,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.IrharenVeteran,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 3
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },


            #endregion

            #region Mercury

                new CardTalent
                {
                    CardId = (int)Enum.CardId.MercurianRecruiter,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ApollodorusMerc,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.ApollodorusMerc,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NewDallasSapper,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NewDallasSapper,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SecondGenColonist,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SecondGenColonist,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NoahtheArchitect,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NoahtheArchitect,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MiningBeliever,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MiningBeliever,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MiningBeliever,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NewDallasOpportunist,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NewDallasOpportunist,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.NewDallasOpportunist,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CalorisBasinTrader,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CalorisBasinTrader,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CalorisBasinTrader,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.AMU,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.AMU,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.AMU,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.OutcastSmuggler,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.OutcastSmuggler,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.OutcastSmuggler,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MiningWalker,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 3
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.MiningWalker,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BobbyMcKendrickTheBoss,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 3
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BobbyMcKendrickTheBoss,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BobbyMcKendrickTheBoss,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },

            #endregion

            #region Titan

                new CardTalent
                {
                    CardId = (int)Enum.CardId.DataMiner,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.OrdinaryServitor,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.SinlapParasyte,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.OracleDroid,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.OracleDroid,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.EbonyFranth,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.EbonyFranth,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BattleDroid,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BattleDroid,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.XanaduLeadLibrarian,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 2
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.XanaduLeadLibrarian,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CyborgBodyguard,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CyborgBodyguard,
                    TalentId = (int)Enum.Talent.Military,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.CyborgBodyguard,
                    TalentId = (int)Enum.Talent.Mining,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BhavyaAdministrator,
                    TalentId = (int)Enum.Talent.Data,
                    Quantity = 3
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BhavyaAdministrator,
                    TalentId = (int)Enum.Talent.Research,
                    Quantity = 3
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.BhavyaAdministrator,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 3
                },

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