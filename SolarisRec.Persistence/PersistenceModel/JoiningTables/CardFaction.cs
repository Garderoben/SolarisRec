namespace SolarisRec.Persistence.PersistenceModel.JoiningTables
{
    public class CardFaction
    {
        public int CardId { get; set; }

        public int FactionId { get; set; }

        public virtual Card Card { get; set; }

        public virtual Faction Faction { get; set; }
    }
}