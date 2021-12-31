using Microsoft.EntityFrameworkCore;
using SolarisRec.Core.Card;
using SolarisRec.Core.Card.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.Persistence.Repositories
{
    internal class CardRepository : ICardRepository
    {
        private readonly SolarisRecDbContext context;
        private readonly IMapToDomainModel<PersistenceModel.Card, Card> persistenceModelMapper;
        private readonly IMapToPersistenceModel<Card, PersistenceModel.Card> domainModelMapper;

        public CardRepository(
            SolarisRecDbContext context,
            IMapToDomainModel<PersistenceModel.Card, Card> persistenceModelMapper,
            IMapToPersistenceModel<Card, PersistenceModel.Card> domainModelMapper)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context)); ;
            this.persistenceModelMapper = persistenceModelMapper ?? throw new ArgumentNullException(nameof(persistenceModelMapper));
            this.domainModelMapper = domainModelMapper ?? throw new ArgumentNullException(nameof(domainModelMapper));
        }

        public async Task<Card> Get(int id)
        {
            var card = await context.Cards
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();

            if(card == null)
            {
                throw new KeyNotFoundException($"Card with Card Id {id} does not exist.");
            }

            return persistenceModelMapper.Map(card);
        }
    }
}