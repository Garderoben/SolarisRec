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



            #endregion

            #region Titan

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