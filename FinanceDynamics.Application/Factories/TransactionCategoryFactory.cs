using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class TransactionCategoryFactory : ITransactionCategoryFactory
    {
        private readonly ITransactionCategoryValidator _transactionCategoryValidator;

        public TransactionCategoryFactory(ITransactionCategoryValidator transactionCategoryValidator)
        {
            _transactionCategoryValidator = transactionCategoryValidator;
        }

        public TransactionCategory Create(NameAndDescription nameAndDescription, List<SubcategoryTransaction>? subcategories)
        {
            _transactionCategoryValidator.ValidateSubcategories(subcategories);

            return new TransactionCategory(nameAndDescription, subcategories);
        }
    }
}