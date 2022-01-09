using SolarisRec.Core.Talent;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Mappers.ToDropdownItems
{
    internal class TalentMapper : IMapToDropdownItem<Talent, DropdownItem>
    {
        public DropdownItem Map(Talent input)
        {
            return new DropdownItem
            {
                Id = input.Id,
                Name = input.Name
            };
        }
    }
}