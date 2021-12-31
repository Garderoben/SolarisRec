using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using System.Collections.Generic;

namespace SolarisRec.Persistence.PersistenceModel
{
    public class Card
    {
        public Card()
        {
            CardTalents = new HashSet<CardTalent>();
            CardResources = new HashSet<CardResource>();
            Factions = new HashSet<Faction>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Ability { get; set; }

        public int Type { get; set; }

        public int? AttackValue { get; set; }

        public int? HealthValue { get; set; }

        //Expansion
        public int ExpansionId { get; set; }

        public Expansion Expansion { get; set; }

        //Faction
        public virtual ICollection<Faction> Factions { get; set; }

        //Talent
        public virtual ICollection<CardTalent> CardTalents { get; set; }

        //Resource
        public virtual ICollection<CardResource> CardResources { get; set; }
    }
}