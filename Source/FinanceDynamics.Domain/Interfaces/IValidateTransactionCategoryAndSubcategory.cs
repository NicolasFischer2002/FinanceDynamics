using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Interfaces
{
    public interface IValidateTransactionCategoryAndSubcategory<TCategory, TSubcategory>
        where TCategory : TransactionCategory
        where TSubcategory : SubcategoryTransaction<TCategory>?
    {
        void Validate(TCategory category, TSubcategory? subcategory);
    }
}