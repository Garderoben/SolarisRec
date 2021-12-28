using Microsoft.Extensions.DependencyInjection;
using SolarisRec.Core.Account;
using SolarisRec.Core.Account.Processes;
using SolarisRec.Core.Account.Processes.PrimaryPorts;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using SolarisRec.Core.Deck.Processes;
using SolarisRec.Core.Deck.Processes.PrimaryPorts;

namespace SolarisRec.Core.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection UseSolarisRecCore(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IDeckBuilderService, DeckBuilderService>()
                .AddTransient<IRegisterAccountService, RegisterAccountService>()
                .AddTransient<ILoginService, LoginService>()
                .AddTransient<IHashPassword, PasswordHasher>();
        }
    }
}