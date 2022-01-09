using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Talent.Processes.SecondaryPorts
{
    public interface ITalentRepository
    {
        Task<List<Talent>> List();
    }
}