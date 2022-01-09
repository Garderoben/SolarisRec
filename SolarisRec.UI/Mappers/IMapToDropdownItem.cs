namespace SolarisRec.UI.Mappers
{
    internal interface IMapToDropdownItem<TData, TDropdown>
    {
        TDropdown Map(TData input);
    }
}