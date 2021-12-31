using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence.Configuration
{
    internal class FactionConfiguration : IEntityTypeConfiguration<Faction>
    {
        public void Configure(EntityTypeBuilder<Faction> builder)
        {
            builder.ToTable("Factions");

            builder.HasIndex(f => f.Name).IsClustered(false).IsUnique();

            builder.Property(f => f.Name)
                .IsRequired(true);

            builder.Property(f => f.Name)
                .HasMaxLength(24);

            builder.HasData
            (
                new Faction
                {
                    Id = 1,
                    Name = "Mars"
                },
                new Faction
                {
                    Id = 2,
                    Name = "Mercury"
                },
                new Faction
                {
                    Id = 3,
                    Name = "Titan"
                },
                new Faction
                {
                    Id = 4,
                    Name = "Bel"
                },
                new Faction
                {
                    Id = 5,
                    Name = "Earth"
                },
                new Faction
                {
                    Id = 6,
                    Name = "Venus"
                }
            );
        }
    }
}