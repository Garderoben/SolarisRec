using SolarisRec.Core.Card;
using System.Collections.Generic;
using System.Linq;

namespace SolarisRec.UI.UIModels
{
    public static class Extensions
    {
        private const int MAX_COUNT = 3;

        public static void AddCard(this Card card, List<DeckItem> deckItems)
        {
            var itemToModify = deckItems.FirstOrDefault(d => d.Name == card.Name);

            if (itemToModify != null)
            {
                if (itemToModify.Quantity < MAX_COUNT)
                {
                    itemToModify.Quantity++;
                }
            }
            else
            {
                deckItems.Add(new DeckItem { Name = card.Name, Quantity = 1});
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