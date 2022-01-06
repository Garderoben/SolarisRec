using SolarisRec.Core.Card.Processes.PrimaryPorts;
using SolarisRec.Core.Card.Processes.SecondaryPorts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Card.Processes
{
    internal class ProvideCardService : IProvideCardService
    {
        private readonly ICardRepository cardRepository;

        public ProvideCardService(
            ICardRepository cardRepository)
        {
            this.cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
        }

        public async Task<Card> Get(int cardId)
        {
            return await cardRepository.Get(cardId);
        }

        public async Task<List<Card>> GetCardsFiltered(Filter filter)
        {
            return await cardRepository.GetCardsFiltered(filter);
        }

        public async Task<List<Card>> GetAll()
        {
            return await cardRepository.GetAll();
        }
    }
}