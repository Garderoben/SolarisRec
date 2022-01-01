using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.Persistence
{
    internal class CardQueryBuilder
    {
        private IQueryable<PersistenceModel.Card> Query;        

        public CardQueryBuilder(SolarisRecDbContext context)
        {            
            Query = context.Set<PersistenceModel.Card>();          
        }        

        public CardQueryBuilder HavingName(string name)
        {
            Query = Query.Where(c => c.Name.Contains(name));

            return this;
        }

        public CardQueryBuilder HavingType(int type)
        {
            Query = Query.Where(c => c.Type == type);

            return this;
        }

        public CardQueryBuilder HavingFaction(int factionId)
        {
            Query = Query.Where(c => c.CardFactions.Any(cf => cf.FactionId == factionId));

            return this;
        }

        public CardQueryBuilder HavingTalent(List<int> talentIds)
        {
            Query = Query.Where(c => c.CardTalents.All(ct => talentIds.Contains(ct.TalentId)));

            return this;
        }        

        public async Task<List<PersistenceModel.Card>> Filter()
        {
            return await Query.ToListAsync();
        }
    }    
}