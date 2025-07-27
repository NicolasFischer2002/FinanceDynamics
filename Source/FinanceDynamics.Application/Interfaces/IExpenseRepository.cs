using FinanceDynamics.Application.ValueObjects;
using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IExpenseRepository
    {
        Task<Expense> GetByIdAsync(int id);
        Task AddAsync(Expense expense);
        Task UpdateAsync(Expense expense);
        Task DeleteAsync(int id);
        Task<IReadOnlyList<Expense>> GetIncomeByDateRange(DateRange dateRange);
        Task<decimal> GetExpenseValueByDateRange(DateRange dateRange);
    }
}