using SolarisRec.UI.UIModels;
using CoreTalent = SolarisRec.Core.Card;

namespace SolarisRec.UI.Mappers.ToUIModel
{
    public class TalentMapper : IMapToUIModel<CoreTalent.Talent, Talent>
    {
        public Talent Map(CoreTalent.Talent input)
        {
            return new Talent
            {
                Quantity = input.Quantity,
                TalentType = input.TalentType
            };
        }
    }
}