using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Application.ValueObjects;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Infrastructure.Data;
using FinanceDynamics.Infrastructure.Data.Mappers;
using Microsoft.EntityFrameworkCore;
using System;

namespace FinanceDynamics.Infrastructure.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly FinanceDbContext _context;

        public IncomeRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Income income)
        {
            Data.Entities.Income incomeData = IncomeMapper.ToData(income);
            _context.Incomes.Add(incomeData);

            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Income> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Income>> GetIncomeByDateRange(DateRange dateRange)
        {
            IReadOnlyList<Data.Entities.Income> incomes = await _context.Incomes
                .Where(i => i.DateTime >= dateRange.StartDate && i.DateTime <= dateRange.EndDate)
                .ToListAsync();

            return incomes.Select(i => IncomeMapper.ToDomain(i)).ToList();
        }

        public Task UpdateAsync(Income income)
        {
            throw new NotImplementedException();
        }

        public async Task<decimal> GetIncomeValueByDateRange(DateRange dateRange)
        {
            return await _context.Incomes
                .Where(i => i.DateTime >= dateRange.StartDate && i.DateTime <= dateRange.EndDate)
                .Select(i => (decimal)i.Value)
                .SumAsync();
        }
    }
}