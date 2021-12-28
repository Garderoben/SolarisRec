using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Account;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.Persistence.Repositories
{
    internal class AccountRepository : IAccountRepository
    {
        private readonly SolarisRecDbContext context;
        private readonly IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper;
        private readonly IMapToPersistenceModel<Account, PersistenceModel.Account> domainModelMapper;

        public AccountRepository(SolarisRecDbContext context,
            IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper,
            IMapToPersistenceModel<Account, PersistenceModel.Account> domainModelMapper)
        {
            this.context = context;
            this.persistenceModelMapper = persistenceModelMapper;
            this.domainModelMapper = domainModelMapper;
        }
       
        public async Task<bool> AccountExists(string accountName)
        {
            return await context.Accounts.AnyAsync(a => a.AccountName == accountName);
        }

        public async Task<bool> EmailExists(string email)
        {
            return await context.Accounts.AnyAsync(a => a.Email == email);
        }

        public async Task<Account> Get(string accountName)
        {
            var account = await context.Accounts
                .Where(a => a.AccountName == accountName)
                .FirstOrDefaultAsync();

            return persistenceModelMapper.Map(account);
        }

        public async Task CreateAccount(Account account)
        {
            var accountToCreate = new PersistenceModel.Account();

            domainModelMapper.Apply(account, accountToCreate);

            await context.Accounts.AddAsync(accountToCreate);
            await context.SaveChangesAsync();
        }
    }
}