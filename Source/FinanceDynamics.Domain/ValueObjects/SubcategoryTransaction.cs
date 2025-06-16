namespace FinanceDynamics.Domain.ValueObjects
{
    public abstract record SubcategoryTransaction<TCategory> where TCategory : TransactionCategory
    {
        public string Name { get; private set; }
        public TCategory Parent { get; private set; }

        public SubcategoryTransaction(string name, TCategory parent)
        {
            Name = name;
            Parent = parent;
        }
    }
}