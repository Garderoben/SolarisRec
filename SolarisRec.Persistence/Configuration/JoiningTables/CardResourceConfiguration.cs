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
                new CardResource
                {
                    CardId = (int)Enum.CardId.Turncoat,
                    ResourceId = (int)Enum.Resource.Beltian,
                    Quantity = 1
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
                }
            );
        }
    }
}