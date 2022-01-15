using SolarisRec.UI.UIModels;
using System.Threading.Tasks;

namespace SolarisRec.UI.Providers
{
    public interface IFactionInformationProvider
    {
        Task<FactionInformation> ProvideFactionInformation(string factioName);
    }
}