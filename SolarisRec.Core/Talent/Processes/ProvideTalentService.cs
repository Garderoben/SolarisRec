using SolarisRec.Core.Talent.Processes.PrimaryPorts;
using SolarisRec.Core.Talent.Processes.SecondaryPorts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.Talent.Processes
{
    internal class ProvideTalentService : IProvideTalentService
    {
        private readonly ITalentRepository talentRepository;

        public ProvideTalentService(ITalentRepository talentRepository)
        {
            this.talentRepository = talentRepository ?? throw new ArgumentNullException(nameof(talentRepository));
        }

        public async Task<List<Talent>> List()
        {
            return await talentRepository.List();
        }
    }
}