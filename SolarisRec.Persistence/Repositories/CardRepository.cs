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
            this.context = context ?? throw new ArgumentNullException(nameof(context));
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

        public async Task<List<Card>> List()
        {
            var result = new List<Card>();

            var allCards =
                await context.Cards
                .Include(c => c.Expansion)
                .Include(c => c.CardFactions)
                    .ThenInclude(cf => cf.Faction)
                .Include(c => c.CardResources)
                    .ThenInclude(cr => cr.Resource)
                .Include(c => c.CardTalents)
                    .ThenInclude(ct => ct.Talent)
                .ToListAsync();


            if (allCards.Count > 0)
            {
                foreach (var card in allCards)
                {
                    result.Add(persistenceModelMapper.Map(card));
                }
            }

            return result;
        }

        public async Task<List<Card>> GetCardsFiltered(Filter filter)
        {
            var result = new List<Card>();

            var allCards =
                await context.Cards
                .Include(c => c.Expansion)
                .Include(c => c.CardFactions)
                    .ThenInclude(cf => cf.Faction)
                .Include(c => c.CardResources)
                    .ThenInclude(cr => cr.Resource)
                .Include(c => c.CardTalents)
                    .ThenInclude(ct => ct.Talent)
                .ToListAsync();

            var filteredCards = allCards.Where
                   (
                       c => (filter.Factions.Count > 0 ? c.CardFactions.Any(cf => filter.Factions.Contains(cf.FactionId)) : 1==1)
                        &&
                       (filter.Talents.All(t => c.CardTalents.Select(ct => ct.TalentId).Contains(t)))
                   ).ToList();                         

            filter.MatchingCardCount = filteredCards.Count;

            var paged = filteredCards
                .Skip((filter.Page - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToList();

            if (paged.Count > 0)
            {
                foreach (var card in paged)
                {
                    result.Add(persistenceModelMapper.Map(card));
                }
            }

            return result;
        }
    }
}