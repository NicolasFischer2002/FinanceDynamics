using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class TransactionCategoryValidator : ITransactionCategoryValidator
    {
        private const int MaximumSubcategories = 5;

        /// <summary>
        /// Validates that the number of subcategories does not exceed the maximum limit.
        /// </summary>
        /// <param name="subcategories">The list of transaction subcategories.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the number of subcategories exceeds the limit.</exception>
        public void ValidateSubcategories(List<SubcategoryTransaction>? subcategories)
        {
            if (subcategories is not null)
                if (subcategories.Count > MaximumSubcategories)
                    throw new ArgumentOutOfRangeException(nameof(subcategories),
                        $"O limite máximo de subcategorias para a transação é de {MaximumSubcategories}. " +
                        $"O número atual de subcategorias é {subcategories.Count}.");
        }
    }
}