using Microsoft.AspNetCore.Components;
using MudBlazor;
using SolarisRec.UI.UIModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Components.Dropdown
{
    public partial class MudMultiSelectDropdown
    {
        [Parameter] public List<DropdownItem> DropdownItems { get; set; }

        [Parameter] public string Label { get; set; }

        [Parameter] public EventCallback<IEnumerable<DropdownItem>> SelectedValuesChanged { get; set; }

        [Parameter] public IEnumerable<DropdownItem> SelectedValues { get; set; }

        private MudSelect<DropdownItem> mudSelect;        

        private async Task SelectionChanged(IEnumerable<DropdownItem> value)
        {
            SelectedValues = value;            
           
            await SelectedValuesChanged.InvokeAsync(SelectedValues);            
        }

        public async Task Clear()
        {            
            await mudSelect.Clear();            
        }
    }
}