using SolarisRec.UI.UIModels;
using CoreCost = SolarisRec.Core.Card;

namespace SolarisRec.UI.Mappers.ToUIModel
{
    internal class CostMapper : IMapToUIModel<CoreCost.Cost, Cost>
    {
        public Cost Map(CoreCost.Cost input)
        {
            return new Cost
            {
                Quantity = input.Quantity,
                ResourceType = input.ResourceType
            };
        }
    }
}