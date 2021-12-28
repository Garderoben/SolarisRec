using System.Threading.Tasks;

namespace SolarisRec.Core.Account.Processes.PrimaryPorts
{
    public interface IRegisterAccountService
    {
        Task CreateAccount(CreateAccountModel createAccountModel);
    }
}