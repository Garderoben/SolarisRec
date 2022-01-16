using SolarisRec.Core.Card.Enums;
using SolarisRec.UI.UIModels;
using System;

namespace SolarisRec.UI.Provdiders
{
    internal static class ResourceIconImageLinkProvider
    {
        public static string Provide(Cost cost)
        {
            return cost.ResourceType switch
            {
                Resource.Beltian => @"../Assets/Belt.jpg",
                Resource.Martian => @"../Assets/Mars.jpg",
                Resource.Mercurian => @"../Assets/Mercury.jpg",
                Resource.Earthian => @"../Assets/Earth.jpg",
                Resource.Titanian => @"../Assets/Titan.jpg",
                Resource.Venusian => @"../Assets/Venus.jpg",
                Resource.Any => @"../Assets/Any.jpg",
                _ => throw new InvalidOperationException($"The resource type {Enum.GetName(cost.ResourceType)} is not supported.")
            };
        }
    }
}