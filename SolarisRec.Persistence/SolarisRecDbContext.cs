using Microsoft.EntityFrameworkCore;
using SolarisRec.Persistence.Configuration;
using SolarisRec.Persistence.Configuration.JoiningTables;
using SolarisRec.Persistence.PersistenceModel;
using SolarisRec.Persistence.PersistenceModel.JoiningTables;

namespace SolarisRec.Persistence
{
    internal class SolarisRecDbContext : DbContext
    {
        public SolarisRecDbContext(DbContextOptions options) : base(options)
        {            
        }        

        public DbSet<Account> Accounts { get; set; }        
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Talent> Talents { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Faction> Factions { get; set; }
        public DbSet<Expansion> Expansions { get; set; }

        public DbSet<CardTalent> CardTalents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new DeckConfiguration());
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new TalentConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new FactionConfiguration());
            modelBuilder.ApplyConfiguration(new ExpansionConfiguration());

            ApplyJoiningTableConfiguration(modelBuilder);
        }

        private static void ApplyJoiningTableConfiguration (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardTalentConfiguration());
            modelBuilder.ApplyConfiguration(new CardResourceConfiguration());
        }
    }
}