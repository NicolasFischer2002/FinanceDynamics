using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Domain.Interfaces
{
    public interface ITransactionCategoryValidator
    {
        void ValidateSubcategories(List<SubcategoryTransaction>? subcategories);
    }
}