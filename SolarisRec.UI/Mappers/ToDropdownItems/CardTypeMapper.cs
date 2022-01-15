using SolarisRec.Core.CardType;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Mappers.ToDropdownItems
{
    internal class CardTypeMapper : IMapToDropdownItem<CardType, DropdownItem>
    {
        public DropdownItem Map(CardType input)
        {
            return new DropdownItem
            {
                Id = input.Id,
                Name = input.Name
            };
        }
    }
}