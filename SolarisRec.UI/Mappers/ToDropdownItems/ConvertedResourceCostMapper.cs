using SolarisRec.Core.ResourceCost;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Mappers.ToDropdownItems
{
    internal class ConvertedResourceCostMapper : IMapToDropdownItem<ConvertedResourceCost, DropdownItem>
    {
        public DropdownItem Map(ConvertedResourceCost input)
        {
            return new DropdownItem
            {
                Id = input.Id,
                Name = input.Value.ToString()
            };
        }
    }
}