namespace SolarisRec.UI.UIModels
{
    public class DropdownItem
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}