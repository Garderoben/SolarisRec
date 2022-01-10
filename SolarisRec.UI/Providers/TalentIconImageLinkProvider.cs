using SolarisRec.Core.Card;
using System;
using Enums = SolarisRec.Core.Card.Enums;

namespace SolarisRec.UI.Provdiders
{
    public static class TalentIconImageLinkProvider
    {
        public static string Provide(Talent talent)
        {
            return talent.TalentType switch
            {
                Enums.Talent.Data => @"../Assets/Data.jpg",
                Enums.Talent.Diplomacy => @"../Assets/Diplomacy.jpg",
                Enums.Talent.Espionage => @"../Assets/Espionage.jpg",
                Enums.Talent.Military => @"../Assets/Military.jpg",
                Enums.Talent.Mining => @"../Assets/Mining.jpg",
                Enums.Talent.Research => @"../Assets/Research.jpg",
                Enums.Talent.Any => @"../Assets/Any.jpg",
                _ => throw new InvalidOperationException($"The talent type {Enum.GetName(talent.TalentType)} is not supported.")
            };
        }
    }
}