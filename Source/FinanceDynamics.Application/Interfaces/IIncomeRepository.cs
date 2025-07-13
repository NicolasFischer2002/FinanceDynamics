using FinanceDynamics.Infrastructure.Data.Entities;
using FinanceDynamics.Infrastructure.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IIncomeRepository
    {
        Task<Income> GetByIdAsync(int id);
        Task AddAsync(Income income);
        Task UpdateAsync(Income income);
        Task DeleteAsync(int id);
        Task<IReadOnlyList<Income>> GetIncomeByDateRange(DateRange dateRange);
    }
}