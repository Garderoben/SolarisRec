using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.Persistence.Configuration.JoiningTables
{
    internal class CardResourceConfiguration : IEntityTypeConfiguration<CardResource>
    {
        public void Configure(EntityTypeBuilder<CardResource> builder)
        {
            builder.ToTable("CardResources");

            builder.HasKey(cr => new { cr.CardId, cr.ResourceId });

            builder.HasOne(cr => cr.Card)
                .WithMany(c => c.CardResources)
                .HasForeignKey(cr => cr.CardId);

            builder.HasOne(cr => cr.Resource)
                .WithMany(r => r.CardResources)
                .HasForeignKey(cr => cr.ResourceId);

            builder.Property(cr => cr.Quantity)
                .IsRequired(true);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<CardResource> builder)
        {
            builder.HasData
            (

            #region Belt

                new CardResource
                {
                    CardId = (int)Enum.CardId.Turncoat,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InsuredColleague,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BeggarInformator,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.KoronisBelter,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.KoronisBelter,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Concubine,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MadameKyung,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Phisher,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Phisher,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.VestaExtortionist,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.VestaExtortionist,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.YoungScum,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.YoungScum,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.VestaThug,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.VestaThug,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.RebelSaboteur,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.RebelSaboteur,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GangLeader,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GangLeader,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MrYue,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MrYue,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GrowingInfection,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GrowingInfection,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Execution,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Execution,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HuntDown,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HuntDown,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OrganDonor,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.YouareTired,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.EyeforanEye,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.EyeforanEye,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Arson,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Arson,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BestoftheBelt,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BestoftheBelt,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 4
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Donorcenter,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.AsteroidIntelStation,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.AsteroidIntelStation,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },

            #endregion

            #region Earth

                new CardResource
                {
                    CardId = (int)Enum.CardId.AcolyteinTraining,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MonkofSol,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SanctionedPriest,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.EarthseedActivist,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.EarthseedActivist,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PeacefulRepresentative,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PeacefulRepresentative,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ReveredMediator,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ReveredMediator,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NegotiatorEld,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ExiledPaladin,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ExiledPaladin,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InvestigatorPaladin,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InvestigatorPaladin,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GuardianPaladin,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GuardianPaladin,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PoliticalAdvisor,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PoliticalAdvisor,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CosmicLinkManager,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CosmicLinkManager,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HeroicRescue,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HeroicRescue,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SawitComing,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ExpendableBodyguard,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IntroducingtoTheFaith,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IntroducingtoTheFaith,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CantTouchMe,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TwistofFate,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TwistofFate,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ScorchedEarthTactic,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ScorchedEarthTactic,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PoliticalDelegation,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PoliticalDelegation,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PoliticalAcademy,
                    ResourceId = (int)Enum.Resource.Earthian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PoliticalAcademy,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },

            #endregion

            #region Mars

                new CardResource
                {
                    CardId = (int)Enum.CardId.MartianDiplomat,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CrimsonGrenadier,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CrimsonLegionInfantry,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SpecialOps,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CrimsonShockTroops,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CrimsonShockTroops,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CrimsonLegionScout,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CrimsonLegionScout,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SergeantJoseph,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ChefuMilitia,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ChefuMilitia,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TarakanGuard,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TarakanGuard,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ChameleonCorps,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ChameleonCorps,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ExplosiveExpert,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ExplosiveExpert,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SupplyLineOfficer,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SupplyLineOfficer,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IrharenVeteran,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IrharenVeteran,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GeneralRwanda,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Headshot,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PreparedAmbush,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.UnexpectedCourage,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.UnexpectedCourage,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DevotedLearning,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DevotedLearning,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MartianEducation,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Aftermath,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ChemicalWarfare,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ChemicalWarfare,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.WarPropaganda,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.WarPropaganda,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OlympusUniversity,
                    ResourceId = (int)Enum.Resource.Martian,
                    Quantity = 2
                },

            #endregion

            #region Mercury

                new CardResource
                {
                    CardId = (int)Enum.CardId.MercurianRecruiter,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ApollodorusMerc,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NewDallasSapper,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NewDallasSapper,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SecondGenColonist,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SecondGenColonist,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NoahtheArchitect,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MiningBeliever,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MiningBeliever,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NewDallasOpportunist,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NewDallasOpportunist,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CalorisBasinTrader,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CalorisBasinTrader,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.AMU,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.AMU,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OutcastSmuggler,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OutcastSmuggler,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MiningWalker,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MiningWalker,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BobbyMcKendrickTheBoss,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BobbyMcKendrickTheBoss,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CombatSteroids,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CombatSteroids,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GiveUporGetUp,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MercifulLoan,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MercifulLoan,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.NabuInsurancePolicy,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InvestmentintheFuture,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.RecycleEverythingthatShines,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.RecycleEverythingthatShines,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PlannedDemolition,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.PlannedDemolition,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BadQualityFuelCells,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BadQualityFuelCells,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CalorStorage,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ApollodorusDock,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ApollodorusDock,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.WalkingFactory,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.WalkingFactory,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.GearingStation,
                    ResourceId = (int)Enum.Resource.Mercurian,
                    Quantity = 1
                },

            #endregion

            #region Titan

                new CardResource
                {
                    CardId = (int)Enum.CardId.DataMiner,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OrdinaryServitor,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OrdinaryServitor,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SinlapParasyte,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SinlapParasyte,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OracleDroid,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.OracleDroid,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BattleDroid,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BattleDroid,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.LigeiaDeveloper,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.LigeiaDeveloper,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.XanaduLeadLibrarian,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.XanaduLeadLibrarian,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.LazarusProtocol,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.LazarusProtocol,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CyborgBodyguard,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CyborgBodyguard,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BhavyaAdministrator,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.BhavyaAdministrator,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IllusionalDistraction,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FatigueoftheFlesh,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FatigueoftheFlesh,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InterplanetaryAssist,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InterplanetaryAssist,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SuddenTurnaround,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SuddenTurnaround,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SilenceYourMind,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DataBreach,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MindOverride,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MindOverride,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.WipetheMind,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.SearchingtheArchives,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.AncientDrives,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DataMine,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.XanaduMemoryVault,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CyberBankOfTitan,
                    ResourceId = (int)Enum.Resource.Titanian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.CyberBankOfTitan,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },

            #endregion

            #region Venus

                new CardResource
                {
                    CardId = (int)Enum.CardId.DisguisedCrew,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DustAddict,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DisciplineofNight,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.DisciplineofNight,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.EvidenceAnalyst,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.EvidenceAnalyst,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.QuasimDaher,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IshtarAssociate,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IshtarAssociate,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TravelingMerchant,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TravelingMerchant,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HiddenCell,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HiddenCell,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MaatMonsSupervisor,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.MaatMonsSupervisor,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FailedExperiment,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FailedExperiment,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Mole,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Mole,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FamedNavigator,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FamedNavigator,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.VioletThorn,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 3
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.VioletThorn,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.UnexpectedExpenses,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.UnexpectedExpenses,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FailedProject,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.FailedProject,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ActofAggression,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ForgedTravelLog,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IntelGathering,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.IntelGathering,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ToxicBlood,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ToxicBlood,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.HologramTrick,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.ImOutofHere,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Misinformation,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.Misinformation,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 2
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InfiltrationAcademy,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.InfiltrationAcademy,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TheShadowDistrict,
                    ResourceId = (int)Enum.Resource.Venusian,
                    Quantity = 1
                },
                new CardResource
                {
                    CardId = (int)Enum.CardId.TheShadowDistrict,
                    ResourceId = (int)Enum.Resource.Any,
                    Quantity = 1
                },

                #endregion

            #region Mission



            #endregion

            );
        }
    }
}