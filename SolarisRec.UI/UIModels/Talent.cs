using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.UI.UIModels
{
    public class Talent
    {
        public int Quantity { get; set; }

        public Enum.Talent TalentType { get; set; }
    }
}