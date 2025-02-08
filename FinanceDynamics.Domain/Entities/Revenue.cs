using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class Revenue : Transaction
    {
        public DateTime? DateOfReceipt { get; private set; }
        public bool? ReceivedLate { get; private set; }

        internal Revenue(User user, TransactionCategory category, TransactionalMethod transactionalMethod, 
            Currency currency, List<Installment> installments, TransactionFile? attachedFile, 
            TransactionStatus transactionStatus, decimal amount, string? description, bool recurring, 
            DateTime date, DateTime? dateOfReceipt, bool? receivedLate) : base(user, category, 
                transactionalMethod, currency, installments, attachedFile, transactionStatus, amount, 
                description, recurring, date)
        {
            DateOfReceipt = dateOfReceipt;
            ReceivedLate = receivedLate;
        }
    }
}