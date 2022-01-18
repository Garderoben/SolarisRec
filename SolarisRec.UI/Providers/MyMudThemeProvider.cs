using MudBlazor;

namespace SolarisRec.UI.Providers
{
    internal static class MyMudThemeProvider
    {
	    public static MudTheme GenerateDefaultTheme() =>
		    new MudTheme()
		    {
			    Palette = new Palette
			    {
				    Background = "#D8DDDC",
				    Surface = "#CBCDCC",
				    DrawerBackground = "#CBCDCC",
				    AppbarBackground = "rgba(0, 0, 0, 0)"
			    },
			    PaletteDark = new Palette
			    {
				    Primary = "#fff",
				    Black = "#27272f",
				    Background = "#000",
				    BackgroundGrey = "#27272f",
				    Surface = "#373740",
				    TextPrimary = "#ffffffb3",
				    TextSecondary = "rgba(255,255,255, 0.50)",
				    AppbarBackground = "rgba(0, 0, 0, 0)",
				    AppbarText = "#fff",
				    TableHover = "#6C6F52"
			    },
			    LayoutProperties = new LayoutProperties()
			    {
				  DefaultBorderRadius  = "0"
			    },
			    Typography = new Typography()
			    {
				    H5 = new H5()
				    {
					    FontFamily = new[] { "Audiowide", "Roboto", "Helvetica", "Arial", "sans-serif" },
					    FontSize = "1.8rem",
					    FontWeight = 500,
					    LineHeight = 1.6,
					    LetterSpacing = ".0075em"
				    },
				    H6 = new H6()
				    {
					    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
					    FontSize = "1.1rem",
					    FontWeight = 500,
					    LineHeight = 1.6,
					    LetterSpacing = ".0075em"
				    },
				    Subtitle1 = new Subtitle1()
				    {
					    FontFamily = new[] { "Audiowide", "Roboto", "Helvetica", "Arial", "sans-serif" },
					    FontSize = ".875rem",
					    LineHeight = 0.8
				    },
				    Body2 = new Body2()
				    {
					    FontFamily = new[] { "electrolize", "Roboto", "Helvetica", "Arial", "sans-serif" },
					    FontSize = "12px",
					    LineHeight = 1,
				    }
			    }
		    };
    }
}
