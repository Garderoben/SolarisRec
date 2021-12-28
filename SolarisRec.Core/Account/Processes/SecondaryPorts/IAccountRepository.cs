using System.Threading.Tasks;

namespace SolarisRec.Core.Account.Processes.SecondaryPorts
{
    public interface IAccountRepository
    {
        Task<bool> AccountExists(string accountName);

        Task<bool> EmailExists(string email);

        public Task<Account> Get(string accountName);

        Task CreateAccount(Account account);
    }
}