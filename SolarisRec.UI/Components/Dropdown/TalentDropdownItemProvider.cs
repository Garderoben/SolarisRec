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
        private readonly IMapToDropdownItem<Core.Talent.Talent, DropdownItem> domainToDropdownMapper;

        public TalentDropdownItemProvider(
            IProvideTalentService provideTalentService,
            IMapToDropdownItem<Core.Talent.Talent, DropdownItem> domainToDropdownMapper)
        {
            this.provideTalentService = provideTalentService ?? throw new ArgumentNullException(nameof(provideTalentService));
            this.domainToDropdownMapper = domainToDropdownMapper ?? throw new ArgumentNullException(nameof(domainToDropdownMapper));
        }

        public async Task<List<DropdownItem>> ProvideDropdownItems()
        {
            var result = new List<DropdownItem>();

            var talents = await provideTalentService.List();

            foreach (var talent in talents)
            {
                if (talent.Id != (int)Core.Card.Enums.Talent.Any)
                {
                    result.Add(domainToDropdownMapper.Map(talent));
                }
            }

            return result;
        }
    }
}