using SolarisRec.Core.Card;

namespace SolarisRec.Persistence.Mappers.ToPersistenceModel
{
    internal class CardMapper : IMapToPersistenceModel<Card, PersistenceModel.Card>
    {
        public void Apply(Card domainModel, PersistenceModel.Card data)
        {
            
        }

        public PersistenceModel.Card CreateNew()
        {
            return new PersistenceModel.Card();
        }
    }
}