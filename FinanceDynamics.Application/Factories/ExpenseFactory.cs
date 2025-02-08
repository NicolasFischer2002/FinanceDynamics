using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class ExpenseFactory : IExpenseFactory
    {
        public Expense Create(User user, TransactionCategory category, TransactionalMethod 
            transactionalMethod, Currency currency, List<Installment> installments, 
            TransactionFile? attachedFile, TransactionStatus transactionStatus, decimal amount, 
            string? description, bool recurring, DateTime date, DateTime dueDate, DateTime? paymentDate, bool? paidLate)
        {
            return new Expense(
                user,
                category,
                transactionalMethod,
                currency,
                installments,
                attachedFile,
                transactionStatus,
                amount,
                description,
                recurring,
                date,
                dueDate,
                paymentDate,
                paidLate
            );
        }
    }
}