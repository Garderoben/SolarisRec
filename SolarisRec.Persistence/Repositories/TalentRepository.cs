using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Talent;
using SolarisRec.Core.Talent.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Persistence.Repositories
{
    internal class TalentRepository : ITalentRepository
    {
        private readonly SolarisRecDbContext context;
        private readonly IMapToDomainModel<PersistenceModel.Talent, Talent> persistenceModelMapper;

        public TalentRepository(
            SolarisRecDbContext context,
            IMapToDomainModel<PersistenceModel.Talent, Talent> persistenceModelMapper)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.persistenceModelMapper = persistenceModelMapper ?? throw new ArgumentNullException(nameof(persistenceModelMapper));
        }

        public async Task<List<Talent>> List()
        {
            var result = new List<Talent>();

            var allTalents = await context.Talents.ToListAsync();

            if (allTalents.Count > 0)
            {
                foreach (var talent in allTalents)
                {
                    result.Add(persistenceModelMapper.Map(talent));
                }
            }

            return result;
        }
    }
}