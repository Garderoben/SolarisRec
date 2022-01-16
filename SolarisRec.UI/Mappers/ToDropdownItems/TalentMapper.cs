using SolarisRec.Core.Talent;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Mappers.ToDropdownItems
{
    internal class TalentMapper : IMapToDropdownItem<Core.Talent.Talent, DropdownItem>
    {
        public DropdownItem Map(Core.Talent.Talent input)
        {
            return new DropdownItem
            {
                Id = input.Id,
                Name = input.Name
            };
        }
    }
}