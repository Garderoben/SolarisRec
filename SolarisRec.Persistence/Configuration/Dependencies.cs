using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SolarisRec.Core.Account.SecondaryPorts;
using SolarisRec.Core.Deck.Processes.SecondaryPorts;
using SolarisRec.Persistence.Repositories;

namespace SolarisRec.Persistence.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection UseSolarisRecPersistenceAdapters(this IServiceCollection serviceCollection, string connectionstring)
        {
            return serviceCollection
                .AddDbContext<SolarisRecDbContext>()
                .AddTransient((s) => CreateSolarisDbContext(connectionstring))
                .AddTransient<IAccountRepo, AccountRepository>()
                .AddTransient<IDeckRepo, DeckRepository>();
        }

        private static SolarisRecDbContext CreateSolarisDbContext(string connectionstring)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SolarisRecDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);
            return new SolarisRecDbContext(optionsBuilder.Options);
        }
    }
}
