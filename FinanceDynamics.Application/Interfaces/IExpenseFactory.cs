using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IExpenseFactory
    {
        Expense Create(User user, TransactionCategory category, TransactionalMethod transactionalMethod,
            Currency currency, List<Installment> installments, TransactionFile? attachedFile,
            TransactionStatus transactionStatus, decimal amount, string? description,
            bool recurring, DateTime date, DateTime dueDate, DateTime? paymentDate, bool? paidLate);
    }
}