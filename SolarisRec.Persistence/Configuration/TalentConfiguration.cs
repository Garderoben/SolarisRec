using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;
using Enum = SolarisRec.Core.Card.Enums;

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

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<Talent> builder)
        {
            builder.HasData
            (
                new Talent
                {
                    Id = (int)Enum.Talent.Yellow,
                    Name = "Yellow"
                },
                new Talent
                {
                    Id = (int)Enum.Talent.Blue,
                    Name = "Blue"
                },
                new Talent
                {
                    Id = (int)Enum.Talent.Red,
                    Name = "Red"
                },
                new Talent
                {
                    Id = (int)Enum.Talent.Black,
                    Name = "Black"
                },
                new Talent
                {
                    Id = (int)Enum.Talent.Green,
                    Name = "Green"
                },
                new Talent
                {
                    Id = (int)Enum.Talent.Purple,
                    Name = "Purple"
                },
                new Talent
                {
                    Id = (int)Enum.Talent.Any,
                    Name = "Any"
                }
            );
        }
    }
}