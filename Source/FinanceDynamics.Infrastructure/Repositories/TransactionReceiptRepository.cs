using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;
using FinanceDynamics.Infrastructure.Data;
using FinanceDynamics.Infrastructure.Data.Mappers;
using Microsoft.EntityFrameworkCore;

namespace FinanceDynamics.Infrastructure.Repositories
{
    public class TransactionReceiptRepository : ITransactionReceiptRepository
    {
        private readonly FinanceDbContext _context;

        public TransactionReceiptRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public async Task<TransactionReceipt?> GetReceipt(string idTransaction, TransactionType transactionType)
        {
            return transactionType switch
            {
                TransactionType.Income => await _context
                    .IncomeTransactionReceipts
                    .Where(itr => itr.GuidId == idTransaction)
                    .FirstOrDefaultAsync()
                    is { } incomeTransactionReceipt
                    ? TransactionReceiptMapper.ToDomain(incomeTransactionReceipt)
                    : null,

                TransactionType.Expense => await _context
                    .ExpenseTransactionReceipts
                    .Where(itr => itr.GuidId == idTransaction)
                    .FirstOrDefaultAsync()
                    is { } expenseTransactionReceipt
                    ? TransactionReceiptMapper.ToDomain(expenseTransactionReceipt)
                    : null,

                _ => null
            };
        }
    }
}