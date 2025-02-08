using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IRevenueFactory
    {
        Revenue Create(User user, TransactionCategory category, TransactionalMethod transactionalMethod,
            Currency currency, List<Installment> installments, TransactionFile? attachedFile,
            TransactionStatus transactionStatus, decimal amount, string? description, bool recurring,
            DateTime date, DateTime? dateOfReceipt, bool? receivedLate);
    }
}