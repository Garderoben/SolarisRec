using SolarisRec.Core.Keyword.Processes.PrimaryPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Keyword.Processes
{
    internal class ProvideKeywordService : IProvideKeywordService
    {
        public ProvideKeywordService()
        {

        }

        public async Task<List<Keyword>> List()
        {
            var result = new List<Keyword>
            {
                new Keyword
                {
                    Id = 1,
                    Name = "Covert"
                },
                new Keyword
                {
                    Id= 2,
                    Name = "Archive"
                },
                new Keyword
                {
                    Id= 3,
                    Name = "Preparing"
                },
                new Keyword
                {
                    Id= 4,
                    Name = "Hasty"
                }
            };

            return await Task.FromResult(result);
        }
    }
}