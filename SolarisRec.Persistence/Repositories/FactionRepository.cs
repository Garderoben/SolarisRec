using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Faction;
using SolarisRec.Core.Faction.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System;
using System.Collections.Generic;
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

            var allFactions = await context.Factions.ToListAsync();

            if(allFactions.Count > 0)
            {
                foreach (var faction in allFactions)
                {
                    result.Add(persistenceModelMapper.Map(faction));
                }
            }

            return result;
        }
    }
}