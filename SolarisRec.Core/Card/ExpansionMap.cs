using System.Collections.Generic;

namespace SolarisRec.Core.Card
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