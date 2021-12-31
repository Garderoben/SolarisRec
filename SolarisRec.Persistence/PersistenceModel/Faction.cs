using System.Collections.Generic;

namespace SolarisRec.Persistence.PersistenceModel
{
    public class Faction
    {
        public Faction()
        {
            Cards = new HashSet<Card>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
