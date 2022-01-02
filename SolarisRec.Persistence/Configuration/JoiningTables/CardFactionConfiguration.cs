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
                    CardId = (int)Enum.CardId.MartianDiplomat,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CrimsonGrenadier,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CrimsonLegionInfantry,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SpecialOps,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CrimsonShockTroops,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CrimsonLegionScout,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SergeantJoseph,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ChefuMilitia,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.TarakanGuard,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ChameleonCorps,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ExplosiveExpert,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SupplyLineOfficer,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.IrharenVeteran,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Headshot,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.PreparedAmbush,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.UnexpectedCourage,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.DevotedLearning,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MartianEducation,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Aftermath,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ChemicalWarfare,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.WarPropaganda,
                    FactionId = (int)Enum.Faction.Mars
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.OlympusUniversity,
                    FactionId = (int)Enum.Faction.Mars
                },

            #endregion

            #region Mercury

                new CardFaction
                {
                    CardId = (int)Enum.CardId.MercurianRecruiter,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ApollodorusMerc,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.NewDallasSapper,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SecondGenColonist,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.NoahtheArchitect,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MiningBeliever,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.NewDallasOpportunist,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CalorisBasinTrader,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.AMU,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.OutcastSmuggler,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MiningWalker,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.BobbyMcKendrickTheBoss,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CombatSteroids,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.GiveUporGetUp,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MercifulLoan,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.NabuInsurancePolicy,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.InvestmentintheFuture,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.RecycleEverythingthatShines,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.PlannedDemolition,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.BadQualityFuelCells,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CalorStorage,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ApollodorusDock,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.WalkingFactory,
                    FactionId = (int)Enum.Faction.Mercury
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.GearingStation,
                    FactionId = (int)Enum.Faction.Mercury
                },

            #endregion

            #region Titan

                new CardFaction
                {
                    CardId = (int)Enum.CardId.DataMiner,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.OrdinaryServitor,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SinlapParasyte,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.OracleDroid,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.EbonyFranth,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.BattleDroid,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.LigeiaDeveloper,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.XanaduLeadLibrarian,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.LazarusProtocol,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CyborgBodyguard,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.BhavyaAdministrator,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.IllusionalDistraction,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.FatigueoftheFlesh,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.InterplanetaryAssist,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SuddenTurnaround,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SilenceYourMind,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.DataBreach,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MindOverride,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.WipetheMind,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.SearchingtheArchives,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.AncientDrives,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.DataMine,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.XanaduMemoryVault,
                    FactionId = (int)Enum.Faction.Titan
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.CyberBankOfTitan,
                    FactionId = (int)Enum.Faction.Titan
                }

            #endregion

            #region Venus

                new CardFaction
                {
                    CardId = (int)Enum.CardId.DisguisedCrew,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.DustAddict,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.DisciplineofNight,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.EvidenceAnalyst,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.QuasimDaher,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.IshtarAssociate,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.TravelingMerchant,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.HiddenCell,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.MaatMonsSupervisor,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.FailedExperiment,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Mole,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.FamedNavigator,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.VioletThorn,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.UnexpectedExpenses,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.FailedProject,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ActofAggression,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ForgedTravelLog,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.IntelGathering,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ToxicBlood,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.HologramTrick,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.ImOutofHere,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.Misinformation,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.InfiltrationAcademy,
                    FactionId = (int)Enum.Faction.Venus
                },
                new CardFaction
                {
                    CardId = (int)Enum.CardId.TheShadowDistrict,
                    FactionId = (int)Enum.Faction.Venus
                },

                #endregion            

            );
        }
    }
}