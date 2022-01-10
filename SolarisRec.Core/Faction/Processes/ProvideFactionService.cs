using SolarisRec.Core.Faction.Processes.PrimaryPorts;
using SolarisRec.Core.Faction.Processes.SecondaryPorts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Faction.Processes
{
    internal class ProvideFactionService : IProvideFactionService
    {
        private readonly IFactionRepository factionRepository;

        public ProvideFactionService(IFactionRepository factionRepository)
        {
            this.factionRepository = factionRepository ?? throw new ArgumentNullException(nameof(factionRepository));
        }

        public async Task<List<Faction>> List()
        {
            return await factionRepository.List();
        }
    }
}