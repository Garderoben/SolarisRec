using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using System.Collections.Generic;

namespace SolarisRec.Persistence.PersistenceModel
{
    public class Resource
    {
        public Resource()
        {
            CardResources = new HashSet<CardResource>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CardResource> CardResources { get; set; }
    }
}