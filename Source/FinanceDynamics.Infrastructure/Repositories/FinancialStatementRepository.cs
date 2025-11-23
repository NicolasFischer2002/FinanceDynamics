using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Application.ValueObjects;
using FinanceDynamics.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanceDynamics.Infrastructure.Repositories
{
    public class FinancialStatementRepository : IFinancialStatement
    {
        private readonly FinanceDbContext _context;

        public FinancialStatementRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public async Task<decimal> BalanceBetweenDates(DateRange dateRange)
        {
            decimal balance = await (
                from i in _context.Incomes
                where i.DateTime >= dateRange.StartDate && i.DateTime <= dateRange.EndDate
                select (decimal)i.Value
            )
            .Concat(
                from e in _context.Expenses
                where e.DateTime >= dateRange.StartDate && e.DateTime <= dateRange.EndDate
                select -(decimal)e.Value
            )
            .SumAsync();

            return balance;
        }
    }
}