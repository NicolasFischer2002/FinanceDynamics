using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Infrastructure.Data;
using FinanceDynamics.Infrastructure.ValueObjects;

namespace FinanceDynamics.Infrastructure.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly FinanceDbContext _context;

        public IncomeRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Income income) // Berlim
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Income> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Income>> GetIncomeByDateRange(DateRange dateRange)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Income income)
        {
            throw new NotImplementedException();
        }
    }
}