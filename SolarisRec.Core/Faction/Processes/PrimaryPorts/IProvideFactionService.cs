using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Faction.Processes.PrimaryPorts
{
    public interface IProvideFactionService
    {
        Task<List<Faction>> List();
    }
}