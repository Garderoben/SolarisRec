using Microsoft.EntityFrameworkCore;

namespace SolarisRec.Persistence.Tests
{
    internal class InMemorySolarisRecDbContext : SolarisRecDbContext
    {
        public InMemorySolarisRecDbContext(string databaseName) : base(CreateOptions(databaseName))
        {

        }

        private static DbContextOptions<SolarisRecDbContext> CreateOptions(string databaseName)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SolarisRecDbContext>();
            return optionsBuilder
                .UseInMemoryDatabase(databaseName)
                .Options;
        }
    }
}