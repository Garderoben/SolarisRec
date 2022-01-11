using System.Collections.Generic;

namespace SolarisRec.Core.Card
{
    public class Filter
    {
        public string Name { get; set; } = string.Empty;

        public List<int> CardTypes { get; set; } = new List<int>();

        public List<int> Talents { get; set; } = new List<int>();

        public List<int> Factions { get; set; } = new List<int>();

        public List<string> Keywords { get; set; } = new List<string>();

        public int PageSize { get; set; } = 8;

        public int Page { get; set; } = 1;

        public int MatchingCardCount { get; set; }
    }
}