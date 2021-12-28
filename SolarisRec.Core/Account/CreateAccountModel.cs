namespace SolarisRec.Core.Account
{
    public class CreateAccountModel
    {
        public string AccountName { get; set; }

        public string Password { get; set; }

        //todo create class for Email
        public string Email { get; set; }
    }
}
