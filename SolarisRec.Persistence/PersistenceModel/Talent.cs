using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using System.Collections.Generic;

namespace SolarisRec.Persistence.PersistenceModel
{
    public class Talent
    {
        public Talent()
        {
            CardTalents = new HashSet<CardTalent>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CardTalent> CardTalents { get; set; }
    }
}