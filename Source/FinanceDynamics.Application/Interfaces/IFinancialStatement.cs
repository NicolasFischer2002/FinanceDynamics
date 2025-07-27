using FinanceDynamics.Application.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IFinancialStatement
    {
        Task<decimal> BalanceBetweenDates(DateRange dateRange);
    }
}