using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class IncomeFactory : IIncomeFactory
    {
        private readonly IValidateTransactionCategoryAndSubcategory<IncomeCategory, IncomeSubcategory> _validator;

        public IncomeFactory(IValidateTransactionCategoryAndSubcategory<IncomeCategory, IncomeSubcategory> validator)
        {
            _validator = validator;
        }

        public Income Create(
            Money value,
            IncomeCategory category,
            IncomeSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null
        )
        {
            _validator.Validate(category, subcategory);

            return new Income(
                value,
                category,
                subcategory,
                method,
                date,
                description,
                receipt
            );
        }
    }
}