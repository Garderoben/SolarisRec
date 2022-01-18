using Microsoft.AspNetCore.Components;
using MudBlazor;
using SolarisRec.UI.Providers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;

namespace SolarisRec.UI.Shared
{
    public partial class AppBar
    {
	    [Parameter]
		public bool IsDarkMode { get; set; }
		
		[Parameter]
		public EventCallback<MouseEventArgs> OnThemeToggled { get; set; }

		private string GetThemeModeIcon()
		{
			if (IsDarkMode)
			{
				return Icons.Material.Filled.Brightness5;
			}
			else
			{
				return Icons.Material.Filled.Brightness4;
			}
		}
    }
}