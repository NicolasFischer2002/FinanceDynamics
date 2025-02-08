using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class TransactionCategory : Category
    {
        public List<SubcategoryTransaction>? Subcategories { get; private set; }

        internal TransactionCategory(NameAndDescription nameAndDescription, List<SubcategoryTransaction>? subcategories)
            : base(nameAndDescription)
        {
            Subcategories = subcategories;
        }
    }
}