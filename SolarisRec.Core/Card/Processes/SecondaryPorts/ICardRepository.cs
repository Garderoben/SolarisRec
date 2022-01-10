using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Card.Processes.SecondaryPorts
{
    public interface ICardRepository
    {
        Task<Card> Get(int id);

        Task<List<Card>> GetCardsFiltered(Filter filter);

        Task<List<Card>> List();
    }
}