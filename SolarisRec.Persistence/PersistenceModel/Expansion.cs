using System.Collections.Generic;

namespace SolarisRec.Persistence.PersistenceModel
{
    public class Expansion
    {
        public Expansion()
        {
            Cards = new HashSet<Card>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}