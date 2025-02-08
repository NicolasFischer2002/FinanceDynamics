namespace FinanceDynamics.Domain.Entities
{
    public abstract class Investment : BaseEntity
    {
        public Guid UserId { get; private set; }
        public decimal Value { get; private set; }
        public decimal TransactionFee { get; private set; }
        public string? Description { get; private set; }
        public DateTime Date { get; private set; }

        protected Investment(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date)
        {
            UserId = userId;
            Value = value;
            TransactionFee = transactionFee;
            Description = description;
            Date = date;
        }
    }
}