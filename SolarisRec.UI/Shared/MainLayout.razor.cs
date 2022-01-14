using MudBlazor;
using SolarisRec.UI.Providers;

namespace SolarisRec.UI.Shared
{
    public partial class MainLayout
    {
        private MudTheme _currentTheme = MyMudThemeProvider.GenerateDarkTheme();
        private bool _sidebarOpen = false;
        private void ToggleTheme(MudTheme changedTheme) => _currentTheme = changedTheme;

        private void ToggleSidebar() => _sidebarOpen = !_sidebarOpen;
    }
}