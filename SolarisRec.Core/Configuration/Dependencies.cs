using Microsoft.Extensions.DependencyInjection;
using SolarisRec.Core.Deck.Processes;
using SolarisRec.Core.Deck.Processes.PrimaryPorts;

namespace SolarisRec.Core.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection UseSolarisRecCore(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IDeckBuilderService, DeckBuilderService>();
        }
    }
}