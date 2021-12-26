using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SolarisRec.Persistence.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection UseSolarisRecPersistenceAdapters(this IServiceCollection serviceCollection, string connectionstring)
        {
            return serviceCollection
                .AddDbContext<SolarisRecDbContext>()
                .AddTransient((s) => CreateSolarisDbContext(connectionstring));
        }

        private static SolarisRecDbContext CreateSolarisDbContext(string connectionstring)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SolarisRecDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);
            return new SolarisRecDbContext(optionsBuilder.Options);
        }
    }
}
