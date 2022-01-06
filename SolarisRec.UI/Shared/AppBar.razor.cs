using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Threading.Tasks;

namespace SolarisRec.UI.Shared
{
    public partial class AppBar
    {
		private bool isLightMode = true;
		private MudTheme currentTheme = new MudTheme();

		[Parameter]
		public EventCallback OnSidebarToggled { get; set; }
		[Parameter]
		public EventCallback<MudTheme> OnThemeToggled { get; set; }

		private async Task ToggleTheme()
		{
			isLightMode = !isLightMode;

			currentTheme = !isLightMode ? GenerateDarkTheme() : new MudTheme();

			await OnThemeToggled.InvokeAsync(currentTheme);
		}

		private MudTheme GenerateDarkTheme() =>
			new MudTheme
			{
				Palette = new Palette()
				{
					Black = "#27272f",
					Background = "#32333d",
					BackgroundGrey = "#27272f",
					Surface = "#373740",
					TextPrimary = "#ffffffb3",
					TextSecondary = "rgba(255,255,255, 0.50)",
					AppbarBackground = "#27272f",
					AppbarText = "#ffffffb3",
					DrawerBackground = "#27272f",
					DrawerText = "#ffffffb3",
					DrawerIcon = "#ffffffb3"
				}
			};
	}
}