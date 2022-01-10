using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Account;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.Persistence.Repositories
{
    internal class AccountRepository : IAccountRepository
    {
        private readonly SolarisRecDbContext context;
        private readonly IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper;
        private readonly IMapToPersistenceModel<Account, PersistenceModel.Account> domainModelMapper;

        public AccountRepository(
            SolarisRecDbContext context,
            IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper,
            IMapToPersistenceModel<Account, PersistenceModel.Account> domainModelMapper)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.persistenceModelMapper = persistenceModelMapper ?? throw new ArgumentNullException(nameof(persistenceModelMapper));
            this.domainModelMapper = domainModelMapper ?? throw new ArgumentNullException(nameof(domainModelMapper));
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

            if (account == null)
            {
                throw new KeyNotFoundException($"Account with Account Name {accountName} does not exist.");
            }
                
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