using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Faction;
using SolarisRec.Core.Faction.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.Persistence.Repositories
{
    internal class FactionRepository : IFactionRepository
    {
        private readonly SolarisRecDbContext context;
        private readonly IMapToDomainModel<PersistenceModel.Faction, Faction> persistenceModelMapper;

        public FactionRepository(
            SolarisRecDbContext context,
            IMapToDomainModel<PersistenceModel.Faction, Faction> persistenceModelMapper)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.persistenceModelMapper = persistenceModelMapper ?? throw new ArgumentNullException(nameof(persistenceModelMapper));
        }

        public async Task<List<Faction>> List()
        {
            var result = new List<Faction>();

            var allFactions = await context.Factions.OrderBy(f => f.Id).ToListAsync();

            if(allFactions.Count > 0)
            {
                for (int i = 0; i < allFactions.Count; i++)
                {
                    result.Add(persistenceModelMapper.Map(allFactions[i]));
                }
            }

            return result;
        }
    }
}