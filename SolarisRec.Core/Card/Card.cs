using System.Collections.Generic;

namespace SolarisRec.Core.Card
{
    public class Card
    {
        public int Id { get; set; }

        public string ExpansionName { get; set; }

        public string Name { get; set; }

        public string Ability { get; set; }

        public string Faction { get; set; }

        public int Type { get; set; }

        public int AttackValue { get; set; }

        public int HealthValue { get; set; }

        public List<Cost> Costs { get; set; }

        public List<Talent> Talents { get; set; }
    }
}