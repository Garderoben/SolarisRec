using SolarisRec.Core.Card;
using SolarisRec.Core.Card.Processes.SecondaryPorts;
using SolarisRec.Persistence.Mappers;
using ToDomainModel = SolarisRec.Persistence.Mappers.ToDomainModel;
using ToPersistenceModel = SolarisRec.Persistence.Mappers.ToPersistenceModel;

namespace SolarisRec.Persistence.Tests.UnitTests.CardRepositoryTests
{
    public abstract class CardRepositoryTestBase
    {
        internal ICardRepository sut;
        internal readonly IMapToDomainModel<PersistenceModel.Card, Card> persistenceModelMapper;
        internal readonly IMapToPersistenceModel<Card, PersistenceModel.Card> domainModelMapper;

        public CardRepositoryTestBase()
        {
            persistenceModelMapper = new ToDomainModel.CardMapper();
            domainModelMapper = new ToPersistenceModel.CardMapper();
        }

        internal abstract SolarisRecDbContext CreateDbContext();
    }
}