using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Infrastructure.Interfaces;

namespace FinanceDynamics.Infrastructure.Mappers
{
    public class CurrencyMapper : IMapper<Currency, Models.Currency>
    {
        public Models.Currency Map(Currency source)
        {
            Models.Currency currency = new Models.Currency();

            currency.Guid = source.Id.ToString();
            currency.Name = source.NameAndDescription.Name;
            currency.Description = source.NameAndDescription.Description;
            currency.Code = source.Code;
            currency.ExchangeRateToUsd = (double)source.ExchangeRateToUSD;

            return currency;
        }
    }
}