namespace SolarisRec.Persistence.PersistenceModel.JoiningTables
{
    public class CardResource
    {
        public int CardId { get; set; }

        public int ResourceId { get; set; }

        public virtual Card Card { get; set; }

        public virtual Resource Resource { get; set; }

        public int Quantity { get; set; }
    }
}