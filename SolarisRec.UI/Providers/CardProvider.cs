using CoreCard = SolarisRec.Core.Card;
using SolarisRec.Core.Card.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Providers
{
    internal class CardProvider : ICardProvider
    {
        private readonly IProvideCardService provideCardService;
        private readonly IMapToUIModel<CoreCard.Card, Card> cardToUIModelMapper;

        public CardProvider(
            IProvideCardService provideCardService,
            IMapToUIModel<CoreCard.Card, Card> cardToUIModelMapper)
        {
            this.provideCardService = provideCardService ?? throw new ArgumentNullException(nameof(provideCardService));
            this.cardToUIModelMapper = cardToUIModelMapper ?? throw new ArgumentNullException(nameof(cardToUIModelMapper));
        }

        public async Task<List<Card>> GetCardsFiltered(CoreCard.CardFilter cardFilter)
        {
            var result = new List<Card>();

            var cards = await provideCardService.GetCardsFiltered(cardFilter);

            foreach (var card in cards)
            {
                result.Add(cardToUIModelMapper.Map(card));
            }

            return result;
        }
    }
}