using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ICurrencyFactory
    {
        Currency Create(NameAndDescription nameAndDescription, string code, decimal exchangeRateToUSD);
    }
}
