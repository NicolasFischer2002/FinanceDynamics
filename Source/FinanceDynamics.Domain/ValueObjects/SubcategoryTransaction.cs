namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed class SubcategoryTransaction
    {
        private string Name { get; set; }

        public SubcategoryTransaction(string name)
        {
            Name = name;
        }
    }
}