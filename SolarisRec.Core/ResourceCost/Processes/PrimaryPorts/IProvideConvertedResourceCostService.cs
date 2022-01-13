using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.ResourceCost.Processes.PrimaryPorts
{
    public interface IProvideConvertedResourceCostService
    {
        Task<List<ConvertedResourceCost>> List();
    }
}