using SolarisRec.Core.Talent;

namespace SolarisRec.Persistence.Mappers.ToDomainModel
{
    internal class TalentMapper : IMapToDomainModel<PersistenceModel.Talent, Talent>
    {
        public Talent Map(PersistenceModel.Talent input)
        {
            return new Talent
            {
                Id = input.Id,
                Name = input.Name
            };
        }
    }
}