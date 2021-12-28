using SolarisRec.Core.Account.Processes.PrimaryPorts;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using System;
using System.Threading.Tasks;

namespace SolarisRec.Core.Account.Processes
{
    internal class LoginService : ILoginService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IHashPassword passwordHasher;

        public LoginService(
            IAccountRepository accountRepository,
            IHashPassword passwordHasher)
        {
            this.accountRepository = accountRepository ?? throw new ArgumentNullException(nameof(accountRepository));
            this.passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
        }

        public async Task<bool> Verify(LoginCredentials credentials)
        {
            var verified = false;

            var accountExists = await accountRepository.AccountExists(credentials.RetrieveAccountName());

            if (!accountExists)
            {
                return accountExists;
            }

            var account = await accountRepository.Get(credentials.RetrieveAccountName());

            if (account != null)
            {
                verified = account.Password == passwordHasher.HashPassword(credentials.RetrievePassword(), account.Salt);
            }

            return verified;
        }
    }
}