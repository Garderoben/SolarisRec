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
        
        [Inject] private IFactionInformationProvider FactionInfoProvider { get; set; }

        [Parameter] public string Id { get; set; }

        private UIModels.FactionInformation FactionInformation { get; set; }

        private ChartOptions ChartOptions { get; set; }

        double[] data = { 0, 0, 0 };
        string[] labels = { "Agents", "Maneuvers", "Constructions" };       

        protected override Task OnInitializedAsync()
        {
            ChartOptions = new ChartOptions
            {
                ChartPalette = new string[]
                {
                    "#5B403E",
                    "#3B3B55",
                    "#8D8D56"
                }
            };

            return base.OnInitializedAsync();
        }

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
            
            FactionInformation = await FactionInfoProvider.ProvideFactionInformation(Id);
            data[0] = FactionInformation.AgentCount;
            data[1] = FactionInformation.ManeuverCount;
            data[2] = FactionInformation.ConstructionCount;
        }
    }
}