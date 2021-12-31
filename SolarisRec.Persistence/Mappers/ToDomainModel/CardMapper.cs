using SolarisRec.Core.Card;
using System.Collections.Generic;

namespace SolarisRec.Persistence.Mappers.ToDomainModel
{
    internal class CardMapper : IMapToDomainModel<PersistenceModel.Card, Card>
    {
        public Card Map(PersistenceModel.Card input)
        {
            return new Card
            {
                Id = input.Id,
                Name = input.Name,
                ExpansionName = input.Expansion.Name,
                ExpansionSerialNumber = input.ExpansionSerialNumber,
                Ability = input.Ability,
                Unique = input.Unique,
                AttackValue = input.AttackValue,
                HealthValue = input.HealthValue,
                Type = input.Type,
                Factions = MapFactions(input.CardFactions),
                Costs = MapCosts(input.CardResources),
                Talents = MapTalents(input.CardTalents)
            };
        }

        private static List<string> MapFactions(ICollection<PersistenceModel.JoiningTables.CardFaction> cardFactions)
        {
            var result = new List<string>();

            if (cardFactions != null)
            {
                foreach (var cardFaction in cardFactions)
                {
                    result.Add(cardFaction.Faction.Name);
                }
            }            

            return result;
        }

        private static List<Cost> MapCosts(ICollection<PersistenceModel.JoiningTables.CardResource> cardResources)
        {
            var result = new List<Cost>();

            if (cardResources != null)
            {
                foreach (var cardResource in cardResources)
                {
                    result.Add(new Cost {
                        ResourceType = (Core.Card.Enums.Resource)cardResource.Resource.Id,
                        Quantity = cardResource.Quantity                        
                    });
                }
            }

            return result;
        }

        private static List<Talent> MapTalents(ICollection<PersistenceModel.JoiningTables.CardTalent> cardTalents)
        {
            var result = new List<Talent>();

            if (cardTalents != null)
            {
                foreach (var cardTalent in cardTalents)
                {
                    result.Add(new Talent {
                        TalentType = (Core.Card.Enums.Talent)cardTalent.Talent.Id,
                        Quantity = cardTalent.Quantity
                    });
                }
            }

            return result;
        }
    }
}