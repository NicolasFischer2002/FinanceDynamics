using FinanceDynamics.Application.DTOs;
using FinanceDynamics.Application.ValueObjects;
using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IIncomeRepository
    {
        Task<Income> GetByIdAsync(int id);
        Task AddAsync(Income income);
        Task UpdateAsync(Income income);
        Task DeleteAsync(string guidId);
        Task<IReadOnlyList<IncomeDTO>> GetIncomeByDateRange(DateRange dateRange);
        Task<decimal> GetIncomeValueByDateRange(DateRange dateRange);
    }
}