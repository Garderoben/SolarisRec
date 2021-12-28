using SolarisRec.Core.Account.Processes.PrimaryPorts;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using System;
using System.Threading.Tasks;

namespace SolarisRec.Core.Account.Processes
{
    internal class RegisterAccountService : IRegisterAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IHashPassword passwordHasher;

        public RegisterAccountService(
            IAccountRepository accountRepository,
            IHashPassword passwordHasher)
        {
            this.accountRepository = accountRepository ?? throw new ArgumentNullException(nameof(accountRepository));
            this.passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
        }

        public async Task CreateAccount(CreateAccountModel createAccountModel)
        {
            string salt = passwordHasher.GenerateSalt();

            string hashedPassword = passwordHasher.HashPassword(createAccountModel.Password, salt);

            var accountNameExists = await accountRepository.AccountExists(createAccountModel.AccountName);

            if(accountNameExists)
            {
                throw new ArgumentException("The given Account Name already exists");
            }

            var emailExists = await accountRepository.EmailExists(createAccountModel.Email);

            if(emailExists)
            {
                throw new ArgumentException("The given Email address already exists");
            }

            var accountToCreate = new Account
            {
                AccountName = createAccountModel.AccountName,
                Email = createAccountModel.Email,
                Salt = salt,
                Password = hashedPassword
            };

            await accountRepository.CreateAccount(accountToCreate);
        }
    }
}