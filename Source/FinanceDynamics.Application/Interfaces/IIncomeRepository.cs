using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Application.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IIncomeRepository
    {
        Task<Income> GetByIdAsync(int id);
        Task AddAsync(Income income);
        Task UpdateAsync(Income income);
        Task DeleteAsync(int id);
        Task<IReadOnlyList<Income>> GetIncomeByDateRange(DateRange dateRange);
        Task<decimal> GetIncomeValueByDateRange(DateRange dateRange);
    }
}