using SolarisRec.Core.CardType;
using SolarisRec.Core.CardType.Processes.PrimaryPorts;
using SolarisRec.UI.Mappers;
using SolarisRec.UI.UIModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Components.Dropdown
{
    internal class CardTypeDropdownProvider : ICardTypeDropdownProvider
    {
        private readonly IProvideCardTypeService provideCardTypeService;
        private readonly IMapToDropdownItem<CardType, DropdownItem> domainToDropdownMapper;

        public CardTypeDropdownProvider(
            IProvideCardTypeService provideCardTypeService,
            IMapToDropdownItem<CardType, DropdownItem> domainToDropdownMapper)
        {
            this.provideCardTypeService = provideCardTypeService ?? throw new ArgumentNullException(nameof(provideCardTypeService));
            this.domainToDropdownMapper = domainToDropdownMapper ?? throw new ArgumentNullException(nameof(domainToDropdownMapper));
        }

        public async Task<List<DropdownItem>> ProvideDropdownItems()
        {
            var result = new List<DropdownItem>();

            var cardTypes = await provideCardTypeService.List();

            foreach (var cardType in cardTypes)
            {
                result.Add(domainToDropdownMapper.Map(cardType));
            }

            return result;
        }
    }
}