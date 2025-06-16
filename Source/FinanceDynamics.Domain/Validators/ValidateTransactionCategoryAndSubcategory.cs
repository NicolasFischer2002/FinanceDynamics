using FinanceDynamics.Domain.Exceptions;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Validators
{
    public class TransactionCategoryValidator<TCategory, TSubcategory>
        : IValidateTransactionCategoryAndSubcategory<TCategory, TSubcategory>
        where TCategory : TransactionCategory
        where TSubcategory : SubcategoryTransaction<TCategory>?
    {
        public void Validate(TCategory category, TSubcategory? subcategory)
        {
            if (subcategory is not null && !ReferenceEquals(subcategory.Parent, category))
            {
                throw new DomainException(
                    $"Subcategoria '{subcategory.Name}' não pertence à categoria '{category.Name}'.", 
                    $"{subcategory.Name}");
            }
        }
    }
}