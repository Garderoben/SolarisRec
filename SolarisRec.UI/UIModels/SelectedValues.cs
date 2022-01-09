using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolarisRec.UI.UIModels
{
    public class SelectedValues : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<DropdownItem> selected;

        public IEnumerable<DropdownItem> Selected
        {
            get { return selected; }
            set 
            { 
                selected = value;
                OnPropertyChanged();
            }
        }

        public SelectedValues()
        {
            Selected = new List<DropdownItem>();    
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}