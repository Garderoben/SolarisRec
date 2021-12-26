using SolarisRec.Core.Account;

namespace SolarisRec.Persistence.Mappers.ToDomainModel
{
    internal class AccountMapper : IMapToDomainModel<PersistenceModel.Account, Account>
    {
        public Account Map(PersistenceModel.Account input)
        {
            return new Account
            {
                Id = input.Id,
                AccountName = input.AccountName,
                Email = input.Email,
                Salt = input.Salt,
                Password = input.Password
            };
        }
    }
}
