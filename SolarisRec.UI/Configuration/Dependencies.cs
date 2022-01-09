using Microsoft.Extensions.DependencyInjection;
using SolarisRec.Core.Faction;
using SolarisRec.Core.Talent;
using SolarisRec.UI.Components.Dropdown;
using SolarisRec.UI.Mappers;
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
                
                .AddTransient<IMapToDropdownItem<Talent, DropdownItem>, Mappers.ToDropdownItems.TalentMapper>()
                .AddTransient<ITalentDropdownItemProvider, TalentDropdownItemProvider>()

                ;
        }       
    }
}