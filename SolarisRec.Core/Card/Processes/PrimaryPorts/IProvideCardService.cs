using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Card.Processes.PrimaryPorts
{
    public interface IProvideCardService
    {
        Task<Card> Get(int cardId);

        Task<List<Card>> GetCardsFiltered(Filter filter);
    }
}