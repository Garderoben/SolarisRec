using System.Collections.Generic;

namespace SolarisRec.Core.Faction
{
    public class FactionInformation
    {
        public Faction Faction { get; set; } = new Faction();

        public List<Card.Card> Cards { get; set; } = new List<Card.Card>();
    }
}