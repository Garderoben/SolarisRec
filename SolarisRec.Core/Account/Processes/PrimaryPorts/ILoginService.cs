using System.Threading.Tasks;

namespace SolarisRec.Core.Account.Processes.PrimaryPorts
{
    public interface ILoginService
    {
        Task<bool> Verify(LoginCredentials credentials);
    }
}