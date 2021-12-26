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
            modelBuilder.ApplyConfiguration(new DeckConfiguration());
        }

        public DbSet<Account> Accounts { get; set; }
        
        public DbSet<Deck> Decks { get; set; }
    }
}