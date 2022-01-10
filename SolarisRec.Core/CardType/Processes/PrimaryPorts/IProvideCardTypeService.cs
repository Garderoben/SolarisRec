using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.CardType.Processes.PrimaryPorts
{
    public interface IProvideCardTypeService
    {
        Task<List<Card.CardType>> List();
    }
}