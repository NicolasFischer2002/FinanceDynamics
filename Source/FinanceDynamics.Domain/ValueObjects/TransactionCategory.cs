namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed class TransactionCategory
    {
        private string Name { get; set; }
        private SubcategoryTransaction? Subcategory { get; set; }

        public TransactionCategory(string name, SubcategoryTransaction? subcategory) 
        {
            Name = name;
            Subcategory = subcategory;
        }
    }
}