using System.Threading.Tasks;

namespace SolarisRec.Core.Faction.Processes.PrimaryPorts
{
    public interface IProvideFactionInformationService
    {
        Task<FactionInformation> ProvideFactionInformation(string factioName);
    }
}
