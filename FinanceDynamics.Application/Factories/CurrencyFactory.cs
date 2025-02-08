using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class CurrencyFactory : ICurrencyFactory
    {
        private readonly ICurrencyValidator _currencyValidator;

        public CurrencyFactory(ICurrencyValidator currencyValidator)
        {
            _currencyValidator = currencyValidator;
        }

        public Currency Create(NameAndDescription nameAndDescription, string code, decimal exchangeRateToUSD)
        {
            _currencyValidator.Validate(code, exchangeRateToUSD);

            return new Currency(nameAndDescription, code, exchangeRateToUSD);
        }
    }
}