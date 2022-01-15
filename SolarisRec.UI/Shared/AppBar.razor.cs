using Microsoft.AspNetCore.Components;
using MudBlazor;
using SolarisRec.UI.Providers;
using System.Threading.Tasks;

namespace SolarisRec.UI.Shared
{
    public partial class AppBar
    {
		private bool isLightMode = false;
		private MudTheme currentTheme = new MudTheme();

		[Parameter]
		public EventCallback OnSidebarToggled { get; set; }
		[Parameter]
		public EventCallback<MudTheme> OnThemeToggled { get; set; }

		private async Task ToggleTheme()
		{
			isLightMode = !isLightMode;

			currentTheme = !isLightMode ? MyMudThemeProvider.GenerateDarkTheme() :MyMudThemeProvider.GenerateLightTheme();

			await OnThemeToggled.InvokeAsync(currentTheme);
		}		
	}
}