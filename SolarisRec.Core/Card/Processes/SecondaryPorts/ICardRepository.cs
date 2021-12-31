using System.Threading.Tasks;

namespace SolarisRec.Core.Card.Processes.SecondaryPorts
{
    public interface ICardRepository
    {
        Task<Card> Get(int id);
    }
}
