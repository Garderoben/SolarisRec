namespace SolarisRec.Persistence.Mappers
{
    interface IMapToPersistenceModel<TDomain, TData>
    {
        void Apply(TDomain domainModel, TData data);

        TData CreateNew();
    }
}