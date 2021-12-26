using SolarisRec.Core.Deck;

namespace SolarisRec.Persistence.Mappers.ToPersistenceModel
{
    class DeckMapper : IMapToPersistenceModel<Deck, PersistenceModel.Deck>
    {
        public void Apply(Deck domainModel, PersistenceModel.Deck data)
        {
            throw new System.NotImplementedException();
        }

        public PersistenceModel.Deck CreateNew()
        {
            throw new System.NotImplementedException();
        }
    }
}