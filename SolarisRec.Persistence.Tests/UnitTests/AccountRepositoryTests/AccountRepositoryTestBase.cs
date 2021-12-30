using SolarisRec.Core.Account;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using ToDomainModel = SolarisRec.Persistence.Mappers.ToDomainModel;
using ToPersistenceModel = SolarisRec.Persistence.Mappers.ToPersistenceModel;

namespace SolarisRec.Persistence.Tests.UnitTests.AccountRepositoryTests
{
    public abstract class AccountRepositoryTestBase
    {
        internal IAccountRepository sut;
        internal readonly IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper;
        internal readonly IMapToPersistenceModel<Account, PersistenceModel.Account> domainModelMapper;

        public AccountRepositoryTestBase()
        {
            persistenceModelMapper = new ToDomainModel.AccountMapper();
            domainModelMapper = new ToPersistenceModel.AccountMapper();
        }

        internal abstract SolarisRecDbContext CreateDbContext();
    }
}