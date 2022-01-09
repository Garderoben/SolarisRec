using SolarisRec.Core.Talent;
using SolarisRec.Core.Talent.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Components.Dropdown
{
    internal class TalentDropdownItemProvider : ITalentDropdownItemProvider
    {
        private readonly IProvideTalentService provideTalentService;
        private readonly IMapToDropdownItem<Talent, DropdownItem> domainToDropdownMapper;

        public TalentDropdownItemProvider(
            IProvideTalentService provideTalentService,
            IMapToDropdownItem<Talent, DropdownItem> domainToDropdownMapper)
        {
            this.provideTalentService = provideTalentService ?? throw new ArgumentNullException(nameof(provideTalentService));
            this.domainToDropdownMapper = domainToDropdownMapper ?? throw new ArgumentNullException(nameof(domainToDropdownMapper));
        }

        public async Task<List<DropdownItem>> ProvideDropdownItems()
        {
            var result = new List<DropdownItem>();

            var factions = await provideTalentService.List();

            foreach (var faction in factions)
            {
                result.Add(domainToDropdownMapper.Map(faction));
            }

            return result;
        }
    }
}