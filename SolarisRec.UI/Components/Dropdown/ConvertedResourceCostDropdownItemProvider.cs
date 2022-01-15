using SolarisRec.Core.ResourceCost;
using SolarisRec.Core.ResourceCost.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Components.Dropdown
{
    internal class ConvertedResourceCostDropdownItemProvider : IConvertedResourceCostDropdownItemProvider
    {
        private readonly IProvideConvertedResourceCostService provideConvertedResourceCostService;
        private readonly IMapToDropdownItem<ConvertedResourceCost, DropdownItem> domainToDropdownMapper;

        public ConvertedResourceCostDropdownItemProvider(
            IProvideConvertedResourceCostService provideConvertedResourceCostService,
            IMapToDropdownItem<ConvertedResourceCost, DropdownItem> domainToDropdownMapper)
        {
            this.provideConvertedResourceCostService = provideConvertedResourceCostService ?? throw new ArgumentNullException(nameof(provideConvertedResourceCostService));
            this.domainToDropdownMapper = domainToDropdownMapper ?? throw new ArgumentNullException(nameof(domainToDropdownMapper));
        }

        public async Task<List<DropdownItem>> ProvideDropdownItems()
        {
            var result = new List<DropdownItem>();

            var convertedResourceCosts = await provideConvertedResourceCostService.List();

            foreach (var convertedResourceCost in convertedResourceCosts)
            {
                result.Add(domainToDropdownMapper.Map(convertedResourceCost));
            }

            return result;
        }
    }
}