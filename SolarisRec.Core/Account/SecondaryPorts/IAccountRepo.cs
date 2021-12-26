using System.Threading.Tasks;

namespace SolarisRec.Core.Account.SecondaryPorts
{
    public interface IAccountRepo
    {
        public Task<Account> Get(int id);
    }
}