namespace SolarisRec.Core.Account.Processes.SecondaryPorts
{
    public interface IHashPassword
    {
        string GenerateSalt();
        string HashPassword(string password, string salt);
    }
}
