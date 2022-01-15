using SolarisRec.Core.Keyword;
using SolarisRec.Core.Keyword.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Components.Dropdown
{
    internal class KeywordDropdownItemProvider : IKeywordDropdownItemProvider
    {
        private readonly IProvideKeywordService provideKeywordService;
        private readonly IMapToDropdownItem<Keyword, DropdownItem> domainToDropdownMapper;

        public KeywordDropdownItemProvider(
            IProvideKeywordService provideKeywordService,
            IMapToDropdownItem<Keyword, DropdownItem> domainToDropdownMapper)
        {
            this.provideKeywordService = provideKeywordService ?? throw new ArgumentNullException(nameof(provideKeywordService));
            this.domainToDropdownMapper = domainToDropdownMapper ?? throw new ArgumentNullException(nameof(domainToDropdownMapper));
        }

        public async Task<List<DropdownItem>> ProvideDropdownItems()
        {
            var result = new List<DropdownItem>();

            var keywords = await provideKeywordService.List();

            foreach (var keyword in keywords)
            {
                result.Add(domainToDropdownMapper.Map(keyword));
            }

            return result;
        }
    }
}