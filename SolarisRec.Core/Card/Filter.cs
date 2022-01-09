using System.Collections.Generic;

namespace SolarisRec.Core.Card
{
    public class Filter
    {
        public string Name { get; set; } = string.Empty;

        public int? Type { get; set; }        

        public List<int> Talents { get; set; } = new List<int>();

        public List<int> Factions { get; set; } = new List<int>();

        public int PageSize { get; set; } = 8;

        public int Page { get; set; } = 1;
    }
}