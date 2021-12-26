using System.Threading.Tasks;

namespace SolarisRec.Core.Deck.Processes.PrimaryPorts
{
    public interface IDeckBuilderService
    {
        Task AddCardToDeck(int cardId, CardQuantity quantity);

        Task RemoveCardsFromDeck(int cardId, CardQuantity quantity);

        Task RemoveAllCardsFromDeck(int cardId);

        Task ClearDeck();

        Task<int> SaveNewDeck();

        Task SaveDeck();

        Task DeleteDeck(int deckId);
    }
}