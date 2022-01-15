using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarisRec.UI.Utility
{
    internal class DeckGenerator : IDeckGenerator
    {
        public string Generate(List<DeckItem> maindeck, List<DeckItem> tacticalDeck, List<DeckItem> missionDeck)
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"Main Deck: {maindeck.Select(d => d.Quantity).Sum()}");

            for (int i = 0; i < maindeck.Count; i++)
            {
                stringBuilder.AppendLine(maindeck[i].Quantity.ToString() + " " + maindeck[i].Name);
            }

            stringBuilder.Append(Environment.NewLine);

            stringBuilder.AppendLine($"Mission Deck: {missionDeck.Select(d => d.Quantity).Sum()}");

            for (int i = 0; i < missionDeck.Count; i++)
            {
                stringBuilder.AppendLine(missionDeck[i].Quantity.ToString() + " " + missionDeck[i].Name);
            }

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendLine($"Tactical Deck: {tacticalDeck.Select(d => d.Quantity).Sum()}");

            for (int i = 0; i < tacticalDeck.Count; i++)
            {
                stringBuilder.AppendLine(tacticalDeck[i].Quantity.ToString() + " " + tacticalDeck[i].Name);
            }

            stringBuilder.Append(Environment.NewLine);

            stringBuilder.Append("Built with SolaricRec by Major Martin");

            return stringBuilder.ToString();
        }
    }
}