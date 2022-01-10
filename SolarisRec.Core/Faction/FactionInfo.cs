using System.Collections.Generic;

namespace SolarisRec.Core.Faction
{
    public class FactionInfo
    {
        public Faction Faction { get; set; }

        public List<Card.Card> Cards { get; set; }
    }
}