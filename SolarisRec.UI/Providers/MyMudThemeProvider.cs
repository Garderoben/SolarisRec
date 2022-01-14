using MudBlazor;

namespace SolarisRec.UI.Providers
{
    public static class MyMudThemeProvider
    {
        public static MudTheme GenerateDarkTheme() =>
			new MudTheme
			{
				Palette = new Palette
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
					DrawerIcon = "#ffffffb3",
					TableHover = "#6C6F52"
				}
			};

		public static MudTheme GenerateLightTheme() =>
			new MudTheme
			{
				Palette = new Palette
				{
					Background = "#D8DDDC",
					Surface = "#CBCDCC",
					DrawerBackground = "#CBCDCC",
					AppbarBackground = "#CBCDCC"
				}
			};
	}
}
