using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Domain.ValueObjects
{
    public class Budget
    {
        public Guid UserId { get; private set; }
        public Dictionary<Guid, Transaction> Transactions { get; private set; }

        internal Budget(Guid userId, Dictionary<Guid, Transaction> transactions)
        {
            UserId = userId;
            Transactions = transactions;
        }
    }
}