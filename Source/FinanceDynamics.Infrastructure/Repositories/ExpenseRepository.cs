using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Application.ValueObjects;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Infrastructure.Data;
using FinanceDynamics.Infrastructure.Data.Mappers;
using Microsoft.EntityFrameworkCore;

namespace FinanceDynamics.Infrastructure.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly FinanceDbContext _context;

        public ExpenseRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Expense expense)
        {
            Data.Entities.Expense expenseData = ExpenseMapper.ToData(expense);
            _context.Expenses.Add(expenseData);

            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expense> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Expense expense)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Expense>> GetIncomeByDateRange(DateRange dateRange)
        {
            IReadOnlyList<Data.Entities.Expense> expenses = await _context.Expenses
                .Where(e => e.DateTime >= dateRange.StartDate && e.DateTime <= dateRange.EndDate)
                .ToListAsync();

            return expenses.Select(e => ExpenseMapper.ToDomain(e)).ToList();
        }

        public async Task<decimal> GetExpenseValueByDateRange(DateRange dateRange)
        {
            return await _context.Expenses
                .Where(e => e.DateTime >= dateRange.StartDate && e.DateTime <= dateRange.EndDate)
                .Select(e => (decimal)e.Value)
                .SumAsync();
        }
    }
}