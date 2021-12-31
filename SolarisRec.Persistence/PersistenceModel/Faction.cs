using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using System.Collections.Generic;

namespace SolarisRec.Persistence.PersistenceModel
{
    public class Faction
    {
        public Faction()
        {
            CardFactions = new HashSet<CardFaction>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CardFaction> CardFactions { get; set; }
    }
}