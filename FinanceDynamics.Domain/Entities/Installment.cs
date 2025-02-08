using FinanceDynamics.Domain.Enums;

namespace FinanceDynamics.Domain.Entities
{
    public class Installment
    {
        public Guid TransactionId { get; private set; }
        public int Number { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime DueDate { get; private set; }
        public InstallmentStatus InstallmentStatus { get; private set; }

        internal Installment(Guid transactionId, int number, decimal amount, DateTime dueDate,
            InstallmentStatus installmentStatus)
        {
            TransactionId = transactionId;
            Number = number;
            Amount = amount;
            DueDate = dueDate;
            InstallmentStatus = installmentStatus;
        }
    }
}