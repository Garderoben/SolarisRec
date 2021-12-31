using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence.Configuration
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            builder.HasIndex(a => a.AccountName).IsClustered(false).IsUnique();
            builder.HasIndex(a => a.Email).IsClustered(false).IsUnique();

            builder.Property(a => a.AccountName)
                .IsRequired(true);

            builder.Property(a => a.Password)
                .IsRequired(true);

            builder.Property(a => a.Email)
                .IsRequired(true);

            builder.Property(a => a.AccountName)
                .HasMaxLength(24);

            builder.Property(a => a.Email).HasColumnType("VARCHAR").HasMaxLength(320);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<Account> builder)
        {
            builder.HasData
            (
                new Account
                {
                    Id = 1,
                    AccountName = "Superuser",
                    Password = "ThisPasswordIsOmegaSecureXD",
                    Email = "major.martin.tibor@gmail.com"
                }
            );
        }
    }
}