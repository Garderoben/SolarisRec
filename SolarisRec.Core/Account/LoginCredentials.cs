using System;

namespace SolarisRec.Core.Account
{
    public class LoginCredentials
    {
        private readonly string accountName;
        private readonly string password;

        public LoginCredentials(string accountName, string password)
        {
            this.accountName = accountName;
            this.password = password;

            if (string.IsNullOrEmpty(accountName))
            {
                throw new ArgumentException("Account Name may not be empty", nameof(accountName));
            }

            if(string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password may not be empty", nameof(password));
            }
        }

        public string RetrieveAccountName()
        {
            return accountName;
        }

        public string RetrievePassword()
        {
            return password;
        }
    }
}