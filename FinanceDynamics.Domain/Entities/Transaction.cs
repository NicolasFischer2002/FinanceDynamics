using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public abstract class Transaction : BaseEntity
    {
        public User User { get; private set; }
        public TransactionCategory Category { get; private set; }
        public TransactionalMethod TransactionalMethod { get; private set; }
        public Currency Currency { get; private set; }
        public List<Installment> Installments { get; private set; }
        public TransactionFile? AttachedFile { get; private set; }
        public TransactionStatus TransactionStatus { get; private set; }
        public decimal Amount { get; private set; }
        public string? Description { get; private set; }
        public bool Recurring { get; private set; }
        /// <summary>
        /// Transaction creation date.
        /// </summary>
        public DateTime Date { get; private set; }

        protected Transaction(User user, TransactionCategory category, TransactionalMethod transactionalMethod,
            Currency currency, List<Installment> installments, TransactionFile? attachedFile,
            TransactionStatus transactionStatus, decimal amount, string? description, bool recurring, DateTime date)
        {
            User = user;
            Category = category;
            TransactionalMethod = transactionalMethod;
            Currency = currency;
            Installments = installments;
            AttachedFile = attachedFile;
            TransactionStatus = transactionStatus;
            Amount = amount;
            Description = description;
            Recurring = recurring;
            Date = date;
        }
    }
}