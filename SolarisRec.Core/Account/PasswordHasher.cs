using SolarisRec.Core.Account.Processes.SecondaryPorts;
using System;
using System.Security.Cryptography;
using System.Text;

namespace SolarisRec.Core.Account
{
    internal class PasswordHasher : IHashPassword
    {
        public string HashPassword(string password, string salt)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes
                (Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(salt), Iteration.GetIteration()))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(20));
            }
        }

        public string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}