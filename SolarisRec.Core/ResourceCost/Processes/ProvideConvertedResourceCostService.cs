using SolarisRec.Core.ResourceCost.Processes.PrimaryPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.ResourceCost.Processes
{
    internal class ProvideConvertedResourceCostService : IProvideConvertedResourceCostService
    {
        public async Task<List<ConvertedResourceCost>> List()
        {
            var result = new List<ConvertedResourceCost>
            {
                new ConvertedResourceCost{ Id = 1, Value = 1},
                new ConvertedResourceCost{ Id = 2, Value = 2},
                new ConvertedResourceCost{ Id = 3, Value = 3},
                new ConvertedResourceCost{ Id = 4, Value = 4},
                new ConvertedResourceCost{ Id = 5, Value = 5},
                new ConvertedResourceCost{ Id = 5, Value = 6}
            };

            return await Task.FromResult(result);
        }
    }
}