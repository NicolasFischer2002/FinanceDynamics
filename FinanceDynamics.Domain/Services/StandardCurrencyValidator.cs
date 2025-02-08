using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class StandardCurrencyValidator : IStandardCurrencyValidator
    {
        /// <summary>
        /// Validates the name to ensure it is not null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="name">The name to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the name is null, empty, or consists only of white-space characters.</exception>
        public void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), $"O parâmetro [{nameof(name)}] não pode ser vazio.");
        }

        /// <summary>
        /// Validates the code to ensure it is not null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="code">The code to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the code is null, empty, or consists only of white-space characters.</exception>
        public void ValidateCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentNullException(nameof(code), $"O parâmetro [{nameof(code)}] não pode ser vazio.");
        }

        /// <summary>
        /// Validates the conversion rate to ensure it is not negative.
        /// </summary>
        /// <param name="conversionRate">The conversion rate to be validated.</param>
        /// <exception cref="ArgumentException">Thrown when the conversion rate is negative.</exception>
        public void ValidateConversionRate(decimal conversionRate)
        {
            if (conversionRate < 0)
                throw new ArgumentException(nameof(conversionRate), "O taxa de conversão não pode ser negativa.");
        }
    }
}