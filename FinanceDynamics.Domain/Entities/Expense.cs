using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class Expense : Transaction
    {
        public DateTime DueDate { get; private set; }
        public DateTime? PaymentDate { get; private set; }
        /// <summary>
        /// The expense may have been paid on time, or late, or may not have been paid yet as it is a 
        /// recurring expense and has not yet been paid.
        /// </summary>
        public bool? PaidLate { get; private set; }

        internal Expense(User user, TransactionCategory category, TransactionalMethod transactionalMethod, 
            Currency currency, List<Installment> installments, TransactionFile? attachedFile,
            TransactionStatus transactionStatus, decimal amount, string? description, 
            bool recurring, DateTime date, DateTime dueDate, DateTime? paymentDate, bool? paidLate)
            : base(user, category, transactionalMethod, currency, installments, attachedFile, 
                  transactionStatus, amount, description, recurring, date)
        {
            DueDate = dueDate;
            PaymentDate = paymentDate;
            PaidLate = paidLate;
        }
    }
}