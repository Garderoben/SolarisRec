using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence.Configuration
{
    internal class ExpansionConfiguration : IEntityTypeConfiguration<Expansion>
    {
        public void Configure(EntityTypeBuilder<Expansion> builder)
        {
            builder.ToTable("Expansions");

            builder.HasIndex(e => e.Name).IsClustered(false).IsUnique();

            builder.Property(e => e.Name)
                .IsRequired(true);

            builder.Property(e => e.Name)
                .HasMaxLength(48);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<Expansion> builder)
        {
            builder.HasData
            (
                new Expansion
                {
                    Id = 1,
                    Name = "So it Begins"
                }
            );
        }
    }
}