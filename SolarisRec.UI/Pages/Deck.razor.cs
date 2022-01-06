using Microsoft.AspNetCore.Components;
using MudBlazor;
using SolarisRec.Core.Card;
using SolarisRec.Core.Card.Processes.PrimaryPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Pages
{
    public partial class Deck
    {
        [Inject]
        public IProvideCardService ProvideCardService { get; set; }

        public List<Card> Cards { get; set; } = new List<Card>();

        private MudTable<Card> table;

        private string ImgSrc { get; set; } = @"../Assets/0Cardback.jpg";

        private readonly int[] pageSizeOption = { 4, 6, 8 };

        //protected override async Task OnInitializedAsync()
        //{
        //    //Cards = await ProvideCardService.GetAll();
        //}

        private async Task<TableData<Card>> GetCardsFiltered(TableState state)
        {
            Filter filter = new Filter
            {
                PageSize = state.PageSize,
                Page = state.Page + 1
            };

            Cards = await ProvideCardService.GetCardsFiltered(filter);

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