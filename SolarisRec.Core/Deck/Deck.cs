using System.Collections.Generic;

namespace SolarisRec.Core.Deck
{
    public class Deck
    {
        private const int MAX_COUNT = 3;

        public Dictionary<string, int> CardList { get; set; } = new Dictionary<string, int>();

        public void AddCard(string cardName)
        {
            if (CardList.ContainsKey(cardName))
            {
                if(CardList[cardName] < MAX_COUNT)
                {
                    CardList[cardName]++;
                }
            }
            else
            {
                CardList.Add(cardName, 1);
            }
        }

        public void RemoveCard(string cardName)
        {
            if (!CardList.ContainsKey(cardName))
            {
                return;
            }
            
            if (CardList[cardName] > 1)
            {
                CardList[cardName]--;
            }

            CardList.Remove(cardName);
        }
    }
}