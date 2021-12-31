using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence.Configuration
{
    internal class TalentConfiguration : IEntityTypeConfiguration<Talent>
    {
        public void Configure(EntityTypeBuilder<Talent> builder)
        {
            builder.ToTable("Talents");

            builder.HasIndex(t => t.Name).IsClustered(false).IsUnique();

            builder.Property(t => t.Name)
                .IsRequired(true);

            builder.Property(t => t.Name)
                .HasMaxLength(24);

            builder.HasData
            (
                new Talent
                {
                    Id = 1,
                    Name = "Yellow"                    
                },
                new Talent
                {
                    Id = 2,
                    Name = "Blue"
                },
                new Talent
                {
                    Id = 3,
                    Name = "Red"
                },
                new Talent
                {
                    Id = 4,
                    Name = "Black"
                },
                new Talent
                {
                    Id = 5,
                    Name = "Green"
                },
                new Talent
                {
                    Id = 6,
                    Name = "Purple"
                },
                new Talent
                {
                    Id = 7,
                    Name = "Any"
                }
            );
        }
    }
}