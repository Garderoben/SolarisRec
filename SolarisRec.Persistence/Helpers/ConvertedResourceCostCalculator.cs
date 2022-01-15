using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using System.Collections.Generic;

namespace SolarisRec.Persistence.Helpers
{
    internal static class ConvertedResourceCostCalculator
    {
        public static int Calculate(IEnumerable<CardResource> cardResources)
        {
            var convertedResourceCost = 0;

            foreach (var cardResource in cardResources)
            {
                convertedResourceCost += cardResource.Quantity;
            }

            return convertedResourceCost;
        }
    }
}