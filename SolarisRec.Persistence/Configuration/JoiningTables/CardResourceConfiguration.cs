using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel.JoiningTables;

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
        }
    }
}
