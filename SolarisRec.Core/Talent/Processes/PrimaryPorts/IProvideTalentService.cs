using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Talent.Processes.PrimaryPorts
{
    public interface IProvideTalentService
    {
        Task<List<Talent>> List();
    }
}