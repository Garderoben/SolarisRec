using SolarisRec.Core.Faction;

namespace SolarisRec.Persistence.Mappers.ToDomainModel
{
    internal class FactionMapper : IMapToDomainModel<PersistenceModel.Faction, Faction>
    {
        public Faction Map(PersistenceModel.Faction input)
        {
            return new Faction
            {
                Id = input.Id,
                Name = input.Name
            };
        }
    }
}