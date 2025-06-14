using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public abstract class Transaction
    {
        private Guid Id { get; set; }
        private Money Value { get; set; }
        private TransactionCategory Category { get; set; }
        private TransactionMethod Method { get; set; }
        private DateTime Date { get; set; }
        private TransactionDescription Description { get; set; }

        protected Transaction(Money value, TransactionCategory category, TransactionMethod method, 
            DateTime date, TransactionDescription description)
        {
            Value = value;
            Category = category;
            Method = method;
            Date = date;
            Description = description;
        }
    }
}