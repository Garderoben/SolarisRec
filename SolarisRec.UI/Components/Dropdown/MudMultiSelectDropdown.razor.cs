using Microsoft.AspNetCore.Components;
using SolarisRec.UI.UIModels;
using System.Collections.Generic;

namespace SolarisRec.UI.Components.Dropdown
{
    public partial class MudMultiSelectDropdown
    {
        [Parameter] public List<DropdownItem> DropdownItems { get; set; }

        [Parameter] public string Label { get; set; }

        [Parameter] public EventCallback<IEnumerable<DropdownItem>> SelectedValuesChanged { get; set; }

        [Parameter] public IEnumerable<DropdownItem> SelectedValues { get; set; }

        private void SelectedFactionsChanged(IEnumerable<DropdownItem> value)
        {
            SelectedValues = value;
            SelectedValuesChanged.InvokeAsync(SelectedValues);
        }
    }
}