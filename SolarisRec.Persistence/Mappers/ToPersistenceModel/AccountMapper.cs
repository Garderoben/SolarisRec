using SolarisRec.Core.Account;

namespace SolarisRec.Persistence.Mappers.ToPersistenceModel
{
    internal class AccountMapper : IMapToPersistenceModel<Account, PersistenceModel.Account>
    {
        public void Apply(Account domainModel, PersistenceModel.Account data)
        {
            data.AccountName = domainModel.AccountName;
            data.Email = domainModel.Email;
            data.Password = domainModel.Password;
            data.Salt = domainModel.Salt;
        }

        public PersistenceModel.Account CreateNew()
        {
            return new PersistenceModel.Account();
        }
    }
}