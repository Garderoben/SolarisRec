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

        public DbSet<Account> Accounts { get; set; }
        
        public DbSet<Deck> Decks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new DeckConfiguration());
        }
    }
}