using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence.Configuration
{
    internal class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable("Resources");

            builder.HasIndex(r => r.Name).IsClustered(false).IsUnique();

            builder.Property(r => r.Name)
                .IsRequired(true);

            builder.Property(r => r.Name)
                .HasMaxLength(24);

            builder.HasData
            (
                new Resource
                {
                    Id = 1,
                    Name = "Martian"
                },
                new Resource
                {
                    Id = 2,
                    Name = "Mercurian"
                },
                new Resource
                {
                    Id = 3,
                    Name = "Titanian"
                },
                new Resource
                {
                    Id = 4,
                    Name = "Beltian"
                },
                new Resource
                {
                    Id = 5,
                    Name = "Earthian"
                },
                new Resource
                {
                    Id = 6,
                    Name = "Venusian"
                },
                new Resource
                {
                    Id = 7,
                    Name = "Any"
                }
            );
        }
    }
}