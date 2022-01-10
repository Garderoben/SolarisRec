using Microsoft.AspNetCore.Components;
using MudBlazor;
using SolarisRec.Core.Card;
using SolarisRec.Core.Card.Processes.PrimaryPorts;
using SolarisRec.UI.Components.Dropdown;
using SolarisRec.UI.UIModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarisRec.UI.Pages
{
    public partial class Deck
    {
        [Inject] public IProvideCardService ProvideCardService { get; set; }
        [Inject] public IFactionDropdownItemProvider FactionDropdownItemProvider { get; set; }
        [Inject] public ITalentDropdownItemProvider TalentDropdownItemProvider { get; set; }
        [Inject] public ICardTypeDropdownProvider CardTypeDropdownItemProvider { get; set; }

        private const int DEFAULT_PAGE_SIZE = 6;

        private MudTable<Card> table;
        private string ImgSrc { get; set; } = @"../Assets/0Cardback.jpg";
        private readonly int[] pageSizeOption = { 4, 6, 8 };
        private List<Card> Cards { get; set; } = new List<Card>();
        private List<DropdownItem> FactionDropdownItems = new();
        private SelectedValues SelectedFactions = new SelectedValues();
        private List<DropdownItem> TalentDropdownItems = new();
        private SelectedValues SelectedTalents = new SelectedValues();
        private List<DropdownItem> CardTypeDropdownItems = new();
        private SelectedValues SelectedCardTypes = new SelectedValues();

        private Filter Filter { get; set; } = new Filter();

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            SelectedFactions.PropertyChanged += async (sender, e) =>
            {
                await InvokeAsync(ApplyDropdownFilters);
            };

            SelectedTalents.PropertyChanged += async (sender, e) =>
            {
                await InvokeAsync(ApplyDropdownFilters);
            };

            SelectedCardTypes.PropertyChanged += async (sender, e) =>
            {
                await InvokeAsync(ApplyDropdownFilters);
            };
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            FactionDropdownItems = await FactionDropdownItemProvider.ProvideDropdownItems();
            TalentDropdownItems = await TalentDropdownItemProvider.ProvideDropdownItems();
            CardTypeDropdownItems = await CardTypeDropdownItemProvider.ProvideDropdownItems();
        }

        private async Task ApplyDropdownFilters()
        {
            await table.ReloadServerData();
        }

        private async Task<TableData<Card>> GetCardsFiltered(TableState state)
        {
            state.PageSize = state.PageSize >= DEFAULT_PAGE_SIZE ? DEFAULT_PAGE_SIZE : state.PageSize;
            table.SetRowsPerPage(state.PageSize);

            Filter.PageSize = state.PageSize;
            Filter.Page = state.Page + 1;
            Filter.Factions = SelectedFactions.Selected.Select(f => f.Id).ToList();
            Filter.Talents = SelectedTalents.Selected.Select(t => t.Id).ToList();
            Filter.CardTypes = SelectedCardTypes.Selected.Select(ct => ct.Id).ToList();

            Cards = await ProvideCardService.GetCardsFiltered(Filter);

            return new TableData<Card>
            {
                Items = Cards,
                TotalItems = Filter.MatchingCardCount
            };
        }

        public void UpdateImageSrc(TableRowClickEventArgs<Card> card)
        {
            ImgSrc = card.Item.ImageSrc;
        }

        private async Task OnSearchByName(string searchTerm)
        {
            Filter.Name = searchTerm;
            await table.ReloadServerData();
        }
    }
}