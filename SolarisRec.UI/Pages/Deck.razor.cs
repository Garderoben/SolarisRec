using Microsoft.AspNetCore.Components;
using SolarisRec.Core.Card;
using SolarisRec.Core.Card.Processes.PrimaryPorts;
using System.Threading.Tasks;

namespace SolarisRec.UI.Pages
{
    public partial class Deck
    {
        [Inject]
        public IProvideCardService ProvideCardService { get; set; }

        public System.Collections.Generic.List<Card> Cards { get; set; } = new System.Collections.Generic.List<Card>();

        protected override async Task OnInitializedAsync()
        {
            Cards = await ProvideCardService.GetAll();
        }
    }
}
