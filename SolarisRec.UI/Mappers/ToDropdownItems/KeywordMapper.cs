using SolarisRec.Core.Keyword;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Mappers.ToDropdownItems
{
    public class KeywordMapper : IMapToDropdownItem<Keyword, DropdownItem>
    {
        public DropdownItem Map(Keyword input)
        {
            return new DropdownItem
            {
                Id = input.Id,
                Name = input.Name
            };
        }
    }
}