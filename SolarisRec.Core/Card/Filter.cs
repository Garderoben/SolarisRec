using System.Collections.Generic;

namespace SolarisRec.Core.Card
{
    public class Filter
    {
        public string Name { get; set; }

        public int? Type { get; set; }

        public int? Faction { get; set; }       

        public List<int> Talents { get; set; }
    }
}