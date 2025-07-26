using System.Globalization;

namespace FinanceDynamics.Application.Services
{
    public static class MoneyFormatter
    {
        public static string Format(decimal value)
        {
            return value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }
    }
}