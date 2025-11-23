using FinanceDynamics.Application.DTOs;
using FinanceDynamics.Domain.Enums;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ITransactionReceiptService
    {
        public Task<ReceiptDTO?> GetReceipt(string idTransaction, TransactionType transactionType);
    }
}