using SolarisRec.Core.Faction;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Mappers.ToDropdownItems
{
    public class FactionMapper : IMapToDropdownItem<Faction, DropdownItem>
    {
        public DropdownItem Map(Faction input)
        {
            return new DropdownItem
            {
                Id = input.Id, 
                Name = input.Name == "Mission" ? "Include Missions" : input.Name
            };
        }
    }
}