using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Account;
using SolarisRec.Core.Account.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.Persistence.Repositories
{
    internal class AccountRepository : IAccountRepo
    {
        private readonly SolarisRecDbContext context;
        private readonly IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper;

        public AccountRepository(SolarisRecDbContext context,
            IMapToDomainModel<PersistenceModel.Account, Account> persistenceModelMapper,
            IMapToPersistenceModel<Account, PersistenceModel.Account> domainModelMapper)
        {
            this.context = context;
            this.persistenceModelMapper = persistenceModelMapper;
        }
       
        public async Task<Account> Get(int id)
        {
            var account = await context.Accounts.Where(a => a.Id == id).FirstOrDefaultAsync();

            return persistenceModelMapper.Map(account);
        }
    }
}