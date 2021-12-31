using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence.Configuration
{
    internal class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Cards");

            builder.Property(c => c.Name)
                .IsRequired(true);

            builder.Property(c => c.Name)
                .HasMaxLength(48);

            builder.Property(c => c.Ability)
                .IsRequired(false);

            builder.Property(c => c.Type)
                .IsRequired(true);

            builder.Property(c => c.AttackValue)
                .IsRequired(false);

            builder.Property(c => c.HealthValue)
                .IsRequired(false);           
        }
    }
}