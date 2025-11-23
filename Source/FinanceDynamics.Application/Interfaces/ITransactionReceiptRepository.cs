using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ITransactionReceiptRepository
    {
        public Task<TransactionReceipt?> GetReceipt(string idTransaction, TransactionType transactionType);
    }
}