using FinanceDynamics.Domain.Interfaces;
using System.Text.RegularExpressions;

namespace FinanceDynamics.Domain.Services
{
    /// <summary>
    /// Provides validation for currency codes and exchange rates.
    /// Ensures compliance with ISO 4217 standards for currency codes 
    /// and validates that exchange rates are within acceptable bounds.
    /// </summary>
    public class CurrencyValidator : ICurrencyValidator
    {
        private readonly ICurrencyValidator _currencyValidator;

        /// <summary>
        /// The maximum reasonable value for an exchange rate.
        /// Values exceeding this threshold will be considered invalid.
        /// </summary>
        private const decimal MaxReasonableRate = 1_000_000M;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyValidator"/> class.
        /// </summary>
        /// <param name="currencyValidator">An instance of <see cref="ICurrencyValidator"/> to delegate validations.</param>
        public CurrencyValidator(ICurrencyValidator currencyValidator)
        {
            _currencyValidator = currencyValidator;
        }

        /// <summary>
        /// Validates the currency code and exchange rate.
        /// </summary>
        /// <param name="code">The currency code to validate.</param>
        /// <param name="exchange">The exchange rate to validate.</param>
        /// <exception cref="ArgumentNullException">Thrown if the currency code is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown if the currency code does not comply with ISO 4217 standards.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the exchange rate is not a positive value or 
        /// exceeds the maximum allowed value.</exception>
        public void Validate(string code, decimal exchange)
        {
            _currencyValidator.ValidateCode(code);
            _currencyValidator.ValidateExchangeRate(exchange);
        }

        /// <summary>
        /// Validates the currency code.
        /// Ensures that the code is not null, empty, or whitespace, 
        /// and adheres to the ISO 4217 standard (3 uppercase letters).
        /// </summary>
        /// <param name="code">The currency code to validate.</param>
        /// <exception cref="ArgumentNullException">Thrown if the code is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown if the code does not follow the ISO 4217 standard.</exception>
        public void ValidateCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentNullException(nameof(code), "O código da moeda não pode ser nulo ou vazio.");

            if (!Regex.IsMatch(code, "^[A-Z]{3}$"))
                throw new ArgumentException("O código da moeda deve consistir em exatamente 3 letras " +
                    "maiúsculas (padrão ISO 4217).",
                    nameof(code));
        }

        /// <summary>
        /// Validates the exchange rate.
        /// Ensures that the exchange rate is a positive value greater than zero
        /// and does not exceed a maximum reasonable threshold.
        /// </summary>
        /// <param name="exchangeRate">The exchange rate to validate.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the exchange rate is not a 
        /// positive value or exceeds the maximum allowed value.</exception>
        public void ValidateExchangeRate(decimal exchangeRate)
        {
            if (exchangeRate <= 0)
                throw new ArgumentOutOfRangeException(nameof(exchangeRate),
                    "A taxa de câmbio deve ser um valor positivo maior que zero.");

            if (exchangeRate > MaxReasonableRate)
                throw new ArgumentOutOfRangeException(nameof(exchangeRate),
                    $"A taxa de câmbio não pode exceder {MaxReasonableRate}.");
        }
    }
}