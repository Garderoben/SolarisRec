namespace SolarisRec.UI.Mappers
{
    public interface IMapToUIModel<TDomain, TUI>
    {
        TUI Map(TDomain input);
    }
}