using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;
using FinanceDynamics.Infrastructure.Data;
using FinanceDynamics.Infrastructure.Data.Entities;
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

        public async Task<bool> DeleteReceipt(string idTransaction, TransactionType transactionType)
        {
            return transactionType switch
            {
                TransactionType.Income => await DeleteFromIncomeAsync(idTransaction),
                TransactionType.Expense => await DeleteFromExpenseAsync(idTransaction),
                _ => false
            };
        }

        private async Task<bool> DeleteFromIncomeAsync(string idTransaction)
        {
            var deleted = await _context
                .IncomeTransactionReceipts
                .Where(itr => itr.GuidId == idTransaction)
                .ExecuteDeleteAsync();

            return deleted > 0;
        }

        private async Task<bool> DeleteFromExpenseAsync(string idTransaction)
        {
            var deleted = await _context
                .ExpenseTransactionReceipts
                .Where(itr => itr.GuidId == idTransaction)
                .ExecuteDeleteAsync();

            return deleted > 0;
        }

        public async Task<bool> AddReceipt(string idTransaction, TransactionType transactionType, TransactionReceipt transactionReceipt)
        {
            return transactionType switch
            {
                TransactionType.Income => await AddFromIncomeAsync(idTransaction, transactionReceipt),
                TransactionType.Expense => await AddFromExpenseAsync(idTransaction, transactionReceipt),
                _ => false
            };
        }

        private async Task<bool> AddFromExpenseAsync(string idTransaction, TransactionReceipt transactionReceipt)
        {
            var expenseReceipt = new ExpenseTransactionReceipt
            {
                GuidId = idTransaction,
                Name = transactionReceipt.GetNameFile(),
                File = transactionReceipt.GetFile()
            };

            await _context.ExpenseTransactionReceipts.AddAsync(expenseReceipt);
            var saved = await _context.SaveChangesAsync();

            return saved == 1;
        }

        private async Task<bool> AddFromIncomeAsync(string idTransaction, TransactionReceipt transactionReceipt)
        {
            var incomeReceipt = new IncomeTransactionReceipt
            {
                GuidId = idTransaction,
                Name = transactionReceipt.GetNameFile(),
                File = transactionReceipt.GetFile()
            };

            await _context.IncomeTransactionReceipts.AddAsync(incomeReceipt);
            var saved = await _context.SaveChangesAsync();

            return saved == 1;
        }
    }
}