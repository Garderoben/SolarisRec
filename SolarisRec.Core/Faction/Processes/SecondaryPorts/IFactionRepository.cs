using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Faction.Processes.SecondaryPorts
{
    public interface IFactionRepository
    {
        Task<List<Faction>> List();

        Task<int> GetFactionId(string factionName);
    }
}