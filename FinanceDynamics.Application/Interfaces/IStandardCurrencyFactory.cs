using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IStandardCurrencyFactory
    {
        Currency Create(NameAndDescription nameAndDescription, string code, decimal conversionRate);
    }
}