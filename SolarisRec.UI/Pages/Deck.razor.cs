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
        //todo: cardtype string, enum? how should I treat it? 
        //todo: UIModel for card?
        //todo: differentiate between UIModels and Helper models?

        [Inject] private IProvideCardService ProvideCardService { get; set; }
        [Inject] private IFactionDropdownItemProvider FactionDropdownItemProvider { get; set; }
        [Inject] private ITalentDropdownItemProvider TalentDropdownItemProvider { get; set; }
        [Inject] private ICardTypeDropdownProvider CardTypeDropdownItemProvider { get; set; }
        [Inject] private IKeywordDropdownItemProvider KeywordDropdownItemProvider { get; set; }
        [Inject] private IConvertedResourceCostDropdownItemProvider ConvertedResourceCostDropdownItemProvider { get; set; }

        private const int DEFAULT_PAGE_SIZE = 8;
        private const int DEFAULT_FROM_MUD_BLAZOR = 10;

        private MudTable<Card> table;
        private MudMultiSelectDropdown factionDropdown;
        private MudMultiSelectDropdown cardTypeDropdown;
        private MudMultiSelectDropdown crcDropdown;
        private MudMultiSelectDropdown talentsDropdown;
        private MudMultiSelectDropdown keywordDropown;
        private MudTextField<string> searchByName;
        private MudTextField<string> searchByAbility;

        private bool reload = true;
        private string ImgSrc { get; set; } = @"../Assets/0Cardback.jpg";
        private readonly int[] pageSizeOption = { 4, 6, 8, 50 };
        private List<Card> Cards { get; set; } = new List<Card>();
        private List<DeckItem> MainDeck { get; set; } = new List<DeckItem>();
        private List<DeckItem> MissionDeck { get; set; } = new List<DeckItem>();
        private List<DeckItem> Sideboard { get; set; } = new List<DeckItem>();

        private List<DropdownItem> FactionDropdownItems = new();
        private SelectedValues SelectedFactions = new ();
        private List<DropdownItem> TalentDropdownItems = new();
        private SelectedValues SelectedTalents = new ();
        private List<DropdownItem> CardTypeDropdownItems = new();
        private SelectedValues SelectedCardTypes = new ();
        private List<DropdownItem> KeywordDropdownItems = new();    
        private SelectedValues SelectedKeywords = new();
        private List<DropdownItem> ConvertedResourceCostDropdownItems = new();
        private SelectedValues SelectedConvertedResourceCosts = new();        

        private Filter Filter { get; set; } = new Filter();        

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            SelectedFactions.PropertyChanged += async (sender, e) =>
            {
                if(reload)
                    await InvokeAsync(ApplyDropdownFilters);
            };

            SelectedCardTypes.PropertyChanged += async (sender, e) =>
            {
                if (reload)
                    await InvokeAsync(ApplyDropdownFilters);
            };

            SelectedConvertedResourceCosts.PropertyChanged += async (sender, e) =>
            {
                if (reload)
                    await InvokeAsync(ApplyDropdownFilters);
            };

            SelectedTalents.PropertyChanged += async (sender, e) =>
            {
                if (reload)
                    await InvokeAsync(ApplyDropdownFilters);
            };

            SelectedKeywords.PropertyChanged += async (sender, e) =>
            {
                if (reload)
                    await InvokeAsync(ApplyDropdownFilters);
            };            
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            FactionDropdownItems = await FactionDropdownItemProvider.ProvideDropdownItems();
            TalentDropdownItems = await TalentDropdownItemProvider.ProvideDropdownItems();
            CardTypeDropdownItems = await CardTypeDropdownItemProvider.ProvideDropdownItems();
            KeywordDropdownItems = await  KeywordDropdownItemProvider.ProvideDropdownItems();            
            ConvertedResourceCostDropdownItems = await ConvertedResourceCostDropdownItemProvider.ProvideDropdownItems();            
        }

        private async Task ApplyDropdownFilters()
        {
            await table.ReloadServerData();
        }

        private async Task<TableData<Card>> GetCardsFiltered(TableState state)
        {
            state.PageSize = state.PageSize == DEFAULT_FROM_MUD_BLAZOR ? DEFAULT_PAGE_SIZE : state.PageSize;
            table.SetRowsPerPage(state.PageSize);

            Filter.PageSize = state.PageSize;
            Filter.Page = state.Page + 1;
            Filter.Factions = SelectedFactions.Selected.Select(f => f.Id).ToList();
            Filter.Talents = SelectedTalents.Selected.Select(t => t.Id).ToList();
            Filter.CardTypes = SelectedCardTypes.Selected.Select(ct => ct.Id).ToList();
            Filter.Keywords = SelectedKeywords.Selected.Select(k => k.Name).ToList();
            Filter.ConvertedResourceCost = SelectedConvertedResourceCosts.Selected.Select(c => c.Id).ToList();            

            if (reload)
            {
                Cards = await ProvideCardService.GetCardsFiltered(Filter);
            }

            return new TableData<Card>
            {
                Items = Cards,
                TotalItems = Filter.MatchingCardCount
            };
        }

        public void UpdateImageSrc(Card card)
        {
            ImgSrc = card.ImageSrc;
        }

        public void UpdateImageSrc(DeckItem deckItem)
        {
            ImgSrc = deckItem.ImageSrc;
        }

        private async Task OnSearchByName(string searchTerm)
        {
            reload = true;

            Filter.Name = searchTerm;
            await table.ReloadServerData();
        }

        private async Task OnSearchByAbility(string abilitySearchTerm)
        {
            reload = true;

            Filter.Ability = abilitySearchTerm;
            await table.ReloadServerData();
        }
        
        private async Task ClearFilters()
        {            
            reload = false;

            await factionDropdown.Clear();
            await cardTypeDropdown.Clear();
            await crcDropdown.Clear();
            await talentsDropdown.Clear();
            await keywordDropown.Clear();
            await searchByName.Clear();
            await searchByAbility.Clear();

            reload = true;

            await table.ReloadServerData();
        }

        private void AddToDeck(TableRowClickEventArgs<Card> card)
        {
            bool isMission = card.Item.Type == nameof(CardTypeConstants.Mission);

            if (card.MouseEventArgs.ShiftKey && !isMission)
            {
                card.Item.AddCard(Sideboard);
                return;
            }

            if (isMission)
            {
                card.Item.AddCard(MissionDeck);
                return;
            } 
            
            card.Item.AddCard(MainDeck);
        }

        private void RemoveFromDeck(TableRowClickEventArgs<DeckItem> deckItem)
        {
            deckItem.Item.RemoveCard(MainDeck);
        }

        private void RemoveFromMissionDeck(TableRowClickEventArgs<DeckItem> deckItem)
        {
            deckItem.Item.RemoveCard(MissionDeck);
        }

        private void RemoveFromSideboard(TableRowClickEventArgs<DeckItem> deckItem)
        {
            deckItem.Item.RemoveCard(Sideboard);
        }
    }
}