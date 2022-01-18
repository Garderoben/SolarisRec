using MudBlazor;
using SolarisRec.UI.Providers;

namespace SolarisRec.UI.Shared
{
    public partial class MainLayout
    {
        private bool isDarkMode = true;
        private MudThemeProvider _mudThemeProvider;
        private MudTheme _currentTheme = MyMudThemeProvider.GenerateDefaultTheme();
        private void ToggleTheme() => isDarkMode = !isDarkMode;
    }
}