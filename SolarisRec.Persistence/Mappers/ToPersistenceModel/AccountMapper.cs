using SolarisRec.Core.Account;

namespace SolarisRec.Persistence.Mappers.ToPersistenceModel
{
    class AccountMapper : IMapToPersistenceModel<Account, PersistenceModel.Account>
    {
        public void Apply(Account domainModel, PersistenceModel.Account data)
        {
            throw new System.NotImplementedException();
        }

        public PersistenceModel.Account CreateNew()
        {
            throw new System.NotImplementedException();
        }
    }
}
