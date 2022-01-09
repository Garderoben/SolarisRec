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

        public List<Card> Cards { get; set; } = new List<Card>();

        public List<DropdownItem> FactionDropdownItems = new();

        IEnumerable<DropdownItem> SelectedFactions = new List<DropdownItem>();

        private MudTable<Card> table;

        private Filter Filter { get; set; } = new Filter();

        private string ImgSrc { get; set; } = @"../Assets/0Cardback.jpg";

        private readonly int[] pageSizeOption = { 4, 6, 8 };        
        
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            FactionDropdownItems = await FactionDropdownItemProvider.ProvideDropdownItems();           
        }

        private async Task<TableData<Card>> GetCardsFiltered(TableState state)
        {
            state.PageSize = state.PageSize >= 8 ? 8 : state.PageSize;
            table.SetRowsPerPage(state.PageSize);

            Filter.PageSize = state.PageSize;
            Filter.Page = state.Page + 1;
            Filter.Factions = SelectedFactions.ToList();

            Cards = await ProvideCardService.GetCardsFiltered(Filter);

            return new TableData<Card>
            {
                Items = Cards,
                TotalItems = 161
            };
        }

        public void UpdateImageSrc(TableRowClickEventArgs<Card> card)
        {
            ImgSrc = card.Item.ImageSrc;
        }       
    }
}