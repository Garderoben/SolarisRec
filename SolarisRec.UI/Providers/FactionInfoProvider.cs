using SolarisRec.Core.Faction;
using System.Threading.Tasks;

namespace SolarisRec.UI.Providers
{
    internal class FactionInfoProvider : IFactionInfoProvider
    {
        public async Task<FactionInfo> ProvideFactionInfo(string factioName)
        {
            var factionInfo = new FactionInfo();

            return await Task.FromResult(factionInfo);
        }
    }
}