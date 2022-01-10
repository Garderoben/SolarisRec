using SolarisRec.Core.Faction;
using System.Threading.Tasks;

namespace SolarisRec.UI.Providers
{
    public interface IFactionInfoProvider
    {
        Task<FactionInfo> ProvideFactionInfo(string factioName);
    }
}