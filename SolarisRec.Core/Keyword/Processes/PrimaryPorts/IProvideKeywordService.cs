using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Keyword.Processes.PrimaryPorts
{
    public interface IProvideKeywordService
    {
        Task<List<Keyword>> List();
    }
}