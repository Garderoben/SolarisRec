using System;

namespace SolarisRec.Persistence.Tests
{
    internal class SolarisRecDbContextBuilder
    {
        private readonly SolarisRecDbContext context;

        internal SolarisRecDbContextBuilder() : this(Guid.NewGuid().ToString())
        {
        }

        internal SolarisRecDbContextBuilder(string dbName)
        {
            context = new InMemorySolarisRecDbContext(dbName);
        }

        public SolarisRecDbContextBuilder WithAccount(PersistenceModel.Account account)
        {
            context.Accounts.Add(account);

            return this;
        }

        public SolarisRecDbContext Build()
        {
            context.SaveChanges();
            return context;
        }
    }
}