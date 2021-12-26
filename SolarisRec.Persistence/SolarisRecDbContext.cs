using Microsoft.EntityFrameworkCore;
using SolarisRec.Persistence.Configuration;
using SolarisRec.Persistence.PersistenceModel;

namespace SolarisRec.Persistence
{
    internal class SolarisRecDbContext : DbContext
    {
        public SolarisRecDbContext(DbContextOptions options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AccountConfiguration());
        }

        public DbSet<Account> Accounts { get; set; }        
    }
}