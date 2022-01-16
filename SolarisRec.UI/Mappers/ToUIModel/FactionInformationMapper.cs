using SolarisRec.Core.CardType;
using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using CoreCard = SolarisRec.Core.Card;

namespace SolarisRec.UI.Mappers.ToUIModel
{
    internal class FactionInformationMapper : IMapToUIModel<Core.Faction.FactionInformation, FactionInformation>
    {
        private readonly IMapToUIModel<CoreCard.Card, Card> cardToUiModelmapper;

        public FactionInformationMapper(
            IMapToUIModel<CoreCard.Card, Card> cardToUiModelmapper)
        {
            this.cardToUiModelmapper = cardToUiModelmapper ?? throw new ArgumentNullException(nameof(cardToUiModelmapper));
        }

        public FactionInformation Map(Core.Faction.FactionInformation input)
        {
            var result = new FactionInformation();

            var cards = MapCards(input.Cards);

            result.AgentCount = GetAgentCount(cards);

            result.ManeuverCount = GetManeuverCount(cards);

            result.ConstructionCount = GetConstructionCount(cards);

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

        private List<Card> MapCards(List<CoreCard.Card> cards)
        {
            var result = new List<Card>();

            foreach (var card in cards)
            {
                result.Add(cardToUiModelmapper.Map(card));
            }

            return result;
        }
    }   
}