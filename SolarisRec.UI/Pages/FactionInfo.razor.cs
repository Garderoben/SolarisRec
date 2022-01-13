using Microsoft.AspNetCore.Components;
using MudBlazor;
using SolarisRec.UI.Providers;
using System.Threading.Tasks;

namespace SolarisRec.UI.Pages
{  
    public partial class FactionInfo
    {
        //Todo: clear up naming
        //Todo: create UI Model(s)
        //Todo: figure out what to display first, adjust UI Model then write mapping
        //Todo: FactionInfo should propably be a UI Model only an all data needed should be mapped from appropriate Core.model       

        [Inject] private IFactionInfoProvider FactionInfoProvider { get; set; }

        [Parameter] public string Id { get; set; }

        private Core.Faction.FactionInfo FactionInformation { get; set; }

        private ChartOptions ChartOptions { get; set; }

        double[] data = { 11, 10, 2 };
        string[] labels = { "Agents", "Maneuvers", "Constructions" };


        protected override Task OnInitializedAsync()
        {
            ChartOptions = new ChartOptions
            {
                ChartPalette = new string[]
                {
                    "#7E1629",
                    "#17583A",
                    "#D2D64A"
                }
            };

            return base.OnInitializedAsync();
        }

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            var test = Id;

            FactionInformation = await FactionInfoProvider.ProvideFactionInfo(Id);
        }
    }
}