using System.Globalization;
using System.Net.NetworkInformation;

namespace FinanceDynamics.Application.Services
{
    public static class MoneyFormatterService
    {
        public static string Format(decimal value)
        {
            return value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        public static string RemoveFormatting(string formattedValue)
        {
            if (decimal.TryParse(formattedValue, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal result))
            {
                return result.ToString("F2", CultureInfo.InvariantCulture);
            }
            
            throw new FormatException("The provided value is not in a valid currency format.");
        }
    }
}