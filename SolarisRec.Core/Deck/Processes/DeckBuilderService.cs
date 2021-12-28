using SolarisRec.Core.Deck.Processes.PrimaryPorts;
using System.Threading.Tasks;

namespace SolarisRec.Core.Deck.Processes
{
    internal class DeckBuilderService : IDeckBuilderService
    {
        public Task AddCardToDeck(int cardId, CardQuantity quantity)
        {
            throw new System.NotImplementedException();
        }

        public Task ClearDeck()
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteDeck(int deckId)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAllCardsFromDeck(int cardId)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveCardsFromDeck(int cardId, CardQuantity quantity)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveDeck()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> SaveNewDeck()
        {
            throw new System.NotImplementedException();
        }
    }
}