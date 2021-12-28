using SolarisRec.Core.Account;
using System.Threading.Tasks;

namespace SolarisRec.UI.Pages
{
    public partial class Index
    {  
        string AccountName { get; set; } = string.Empty;

        string Password { get; set; } = string.Empty;

        string Email { get; set; } = string.Empty;

        string LoggedInAs { get; set; } = string.Empty;             

        public async Task Create()
        {
            var accountToCreate = new CreateAccountModel
            {
                AccountName = this.AccountName,
                Password = this.Password,
                Email = this.Email
            };

            await registerAccountService.CreateAccount(accountToCreate);
        }

        public async Task Login()
        {
            var credentials = new LoginCredentials(AccountName, Password);

            var verified = await loginService.Verify(credentials);

            if(verified)
            {
                LoggedInAs = AccountName;
            }
        }
    }
}