namespace SolarisRec.Persistence.PersistenceModel.JoiningTables
{
    public class CardTalent
    {        
        public int CardId { get; set; }
        
        public int TalentId { get; set; }

        public virtual Card Card { get; set; }

        public virtual Talent Talent { get; set; }

        public int Quantity { get; set; }
    }
}