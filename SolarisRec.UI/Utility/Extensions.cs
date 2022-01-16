using SolarisRec.Core.CardType;
using SolarisRec.UI.UIModels;
using System.Collections.Generic;
using System.Linq;

namespace SolarisRec.UI.Utility
{
    public static class Extensions
    {
        private const int MAX_COUNT = 3;
        private const int MISSION = 1;

        public static void AddCard(this Card card, List<DeckItem> deckItems)
        {
            int upperLimit = card.Type == CardTypeConstants.Mission ? MISSION : MAX_COUNT;

            var itemToModify = deckItems.FirstOrDefault(d => d.Name == card.Name);

            if (itemToModify != null)
            {
                if (itemToModify.Quantity < upperLimit)
                {
                    itemToModify.Quantity++;
                }
            }
            else
            {
                deckItems.Add(new DeckItem { Name = card.Name, Quantity = 1, ImageSrc = card.ImageSrc});
            }
        }

        public static void RemoveCard(this DeckItem deckItem, List<DeckItem> deckItems)
        {
            var itemToModify = deckItems.FirstOrDefault(d => d.Name == deckItem.Name);

            if(itemToModify == null)
            {
                return;
            }

            if(itemToModify.Quantity > 1)
            {
                itemToModify.Quantity--;
                return;
            }            

            deckItems.Remove(itemToModify);
        }
    }
}