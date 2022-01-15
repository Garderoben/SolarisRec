using SolarisRec.Core.Faction.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.UIModels;
using System;
using System.Threading.Tasks;

namespace SolarisRec.UI.Providers
{
    internal class FactionInformationProvider : IFactionInformationProvider
    {
        private IProvideFactionInformationService provideFactionInformationService;
        private IMapToUIModel<Core.Faction.FactionInformation, FactionInformation> factionInformationMapper;

        public FactionInformationProvider(
            IProvideFactionInformationService provideFactionInformationService,
            IMapToUIModel<Core.Faction.FactionInformation, FactionInformation> factionInformationMapper)
        {
            this.provideFactionInformationService = provideFactionInformationService ?? throw new ArgumentNullException(nameof(provideFactionInformationService));
            this.factionInformationMapper = factionInformationMapper ?? throw new ArgumentNullException(nameof(factionInformationMapper));
        }

        public async Task<FactionInformation> ProvideFactionInformation(string factioName)
        {
            var factionInformation = await provideFactionInformationService.ProvideFactionInformation(factioName);

            var result = factionInformationMapper.Map(factionInformation);

            return result;
        }
    }
}