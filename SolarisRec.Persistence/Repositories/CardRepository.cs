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
        private readonly CardQueryBuilder cardQueryBuilder;
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

            this.cardQueryBuilder = new CardQueryBuilder(this.context);
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

        public async Task<List<Card>> GetCardsFiltered(Filter filter)
        {
            var result = new List<Card>();

            if(!string.IsNullOrEmpty(filter.Name))
            {
                cardQueryBuilder.HavingName(filter.Name);
            }

            if(filter.Type != null)
            {
                cardQueryBuilder.HavingType((int)filter.Type);
            }

            if(filter.Faction != null)
            {                
                cardQueryBuilder.HavingFaction((int)filter.Faction);                
            }

            if (filter.Talents != null && filter.Talents.Count > 0)
            {
                cardQueryBuilder.HavingTalent(filter.Talents);
            }            

            var filtered = await cardQueryBuilder.Filter();

            if(result.Count > 0)
            {
                foreach(var card in filtered)
                {
                    result.Add(persistenceModelMapper.Map(card));
                }
            }

            return result;
        }
    }
}