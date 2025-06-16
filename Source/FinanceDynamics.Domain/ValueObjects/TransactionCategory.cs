namespace FinanceDynamics.Domain.ValueObjects
{
    public abstract record TransactionCategory
    {
        public string Name { get; private set; }

        public TransactionCategory(string name)
        {
            Name = name;
        }
    }
}