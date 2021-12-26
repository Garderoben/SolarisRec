namespace SolarisRec.Persistence.PersistenceModel
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountName { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public string Email { get; set; }
    }
}