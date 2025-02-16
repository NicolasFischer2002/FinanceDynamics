using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Domain.Interfaces
{
    public interface ICurrencyRepository
    {
        ValueTask Add(Currency currency);
        Currency FindByCode(string code);
    }
}