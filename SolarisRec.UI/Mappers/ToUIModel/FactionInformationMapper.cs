using SolarisRec.Core.Card;
using SolarisRec.UI.UIModels;
using System.Collections.Generic;
using System.Linq;

namespace SolarisRec.UI.Mappers.ToUIModel
{
    internal class FactionInformationMapper : IMapToUIModel<Core.Faction.FactionInformation, FactionInformation>
    {
        public FactionInformation Map(Core.Faction.FactionInformation input)
        {
            var result = new FactionInformation();

            result.AgentCount = GetAgentCount(input.Cards);

            result.ManeuverCount = GetManeuverCount(input.Cards);

            result.ConstructionCount = GetConstructionCount(input.Cards);

            return result;
        }

        private static int GetAgentCount(List<Card> cards)
        {
            return cards.Where(c => c.Type == nameof(CardTypeConstants.Agent)).Count();
        }

        private static int GetManeuverCount(List<Card> cards)
        {
            return cards.Where(c => c.Type == nameof(CardTypeConstants.Maneuver)).Count();
        }

        private static int GetConstructionCount(List<Card> cards)
        {
            return cards.Where(c => c.Type == nameof(CardTypeConstants.Construction)).Count();
        }
    }   
}