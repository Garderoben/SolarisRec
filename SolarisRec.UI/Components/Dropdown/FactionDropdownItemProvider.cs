using SolarisRec.Core.Faction;
using SolarisRec.Core.Faction.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Components.Dropdown
{
    internal class FactionDropdownItemProvider : IFactionDropdownItemProvider
    {
        private readonly IProvideFactionService provideFactionService;
        private readonly IMapToDropdownItem<Faction, DropdownItem> domainToDropdownMapper;

        public FactionDropdownItemProvider(
            IProvideFactionService provideFactionService,
            IMapToDropdownItem<Faction, DropdownItem> domainToDropdownMapper)
        {
            this.provideFactionService = provideFactionService ?? throw new ArgumentNullException(nameof(provideFactionService));
            this.domainToDropdownMapper = domainToDropdownMapper ?? throw new ArgumentNullException(nameof(domainToDropdownMapper));
        }

        public async Task<List<DropdownItem>> ProvideDropdownItems()
        {
            var result = new List<DropdownItem>();

            var factions = await provideFactionService.List();

            foreach(var faction in factions)
            {
                result.Add(domainToDropdownMapper.Map(faction));
            }

            return result;
        }
    }
}