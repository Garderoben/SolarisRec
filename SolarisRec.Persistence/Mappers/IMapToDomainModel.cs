namespace SolarisRec.Persistence.Mappers
{
    interface IMapToDomainModel<TData, TDomain>
    {
        TDomain Map(TData input);        
    }
}