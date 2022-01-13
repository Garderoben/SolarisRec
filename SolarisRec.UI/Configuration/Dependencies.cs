using Microsoft.Extensions.DependencyInjection;
using SolarisRec.Core.CardType;
using SolarisRec.Core.Faction;
using SolarisRec.Core.Keyword;
using SolarisRec.Core.ResourceCost;
using SolarisRec.UI.Components.Dropdown;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.Providers;
using SolarisRec.UI.UIModels;

namespace SolarisRec.UI.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection UseSolarisRecUi(this IServiceCollection serviceCollection)
        {
            return serviceCollection                
                .AddTransient<IMapToDropdownItem<Faction, DropdownItem>, Mappers.ToDropdownItems.FactionMapper>()
                .AddTransient<IFactionDropdownItemProvider, FactionDropdownItemProvider>()
                
                .AddTransient<IMapToDropdownItem<Core.Talent.Talent, DropdownItem>, Mappers.ToDropdownItems.TalentMapper>()
                .AddTransient<ITalentDropdownItemProvider, TalentDropdownItemProvider>()

                .AddTransient<IMapToDropdownItem<CardType, DropdownItem>, Mappers.ToDropdownItems.CardTypeMapper>()
                .AddTransient<ICardTypeDropdownProvider, CardTypeDropdownProvider>()

                .AddTransient<IMapToDropdownItem<Keyword, DropdownItem>, Mappers.ToDropdownItems.KeywordMapper>()
                .AddTransient<IKeywordDropdownItemProvider, KeywordDropdownItemProvider>()

                .AddTransient<IMapToDropdownItem<ConvertedResourceCost, DropdownItem>, Mappers.ToDropdownItems.ConvertedResourceCostMapper>()
                .AddTransient<IConvertedResourceCostDropdownItemProvider, ConvertedResourceCostDropdownItemProvider>()

                .AddTransient<IFactionInfoProvider, FactionInfoProvider>()
                ;
        }       
    }
}