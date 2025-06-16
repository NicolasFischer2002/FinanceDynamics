using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class ExpenseFactory : IExpenseFactory
    {
        private readonly IValidateTransactionCategoryAndSubcategory<ExpenseCategory, ExpenseSubcategory> _validator;

        public ExpenseFactory(IValidateTransactionCategoryAndSubcategory<ExpenseCategory, ExpenseSubcategory> validator)
        {
            _validator = validator;
        }

        public Expense Create(
            Money value,
            ExpenseCategory category,
            ExpenseSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null
        )
        {
            _validator.Validate(category, subcategory);

            return new Expense(
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