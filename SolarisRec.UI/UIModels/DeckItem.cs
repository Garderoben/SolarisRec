namespace SolarisRec.UI.UIModels
{
    public class DeckItem
    {
        public string Name { get; set; }

        public int Quantity { get; set; }
        
        public string ImageSrc { get; set; }

        public int CardType { get; set; }
        
        public int ConvertedCost { get; set; }
    }
}