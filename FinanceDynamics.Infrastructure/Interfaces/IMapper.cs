namespace FinanceDynamics.Infrastructure.Interfaces
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
    }
}