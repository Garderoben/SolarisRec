using SolarisRec.Core.Card;
using System.Collections.Generic;

namespace SolarisRec.UI.Utility
{
    internal static class ExpansionMap
    {
        private static Dictionary<string, string> Mapping => new Dictionary<string, string>
        {
            {
                "So it Begins",
                ExpansionNames.SoItBegins
            }
        };

        public static string Map(string expansionName)
        {
            Mapping.TryGetValue(expansionName, out string value);

            return value;
        }
    }
}