using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class StandardCurrencyFactory : IStandardCurrencyFactory
    {
        private readonly IStandardCurrencyValidator _standardCurrencyValidator;

        public StandardCurrencyFactory(IStandardCurrencyValidator standardCurrencyValidator)
        {
            _standardCurrencyValidator = standardCurrencyValidator;
        }

        public Currency Create(NameAndDescription nameAndDescription, string code, decimal conversionRate)
        {
            _standardCurrencyValidator.ValidateCode(code);
            _standardCurrencyValidator.ValidateConversionRate(conversionRate);

            return new Currency(nameAndDescription, code, conversionRate);
        }
    }
}