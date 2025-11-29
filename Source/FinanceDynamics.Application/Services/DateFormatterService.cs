namespace FinanceDynamics.Application.Services
{
    public static class DateFormatterService
    {
        public static string Format_dd_MM_yyyy(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }
    }
}