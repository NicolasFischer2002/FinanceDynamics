using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Helpers;
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

        public Expense Create(
            decimal value,
            string category,
            string? subcategory,
            string method,
            DateTime date,
            string? description = null,
            TransactionReceipt? receipt = null)
        {
            Money money = new Money(value);
            ExpenseCategory expenseCategory = new ExpenseCategory(category);
            ExpenseSubcategory? subCategoryExpense =
                subcategory != null ? new ExpenseSubcategory(subcategory, expenseCategory) : null;
            TransactionMethod transactionMethod = EnumHelper.GetValueFromDescription<TransactionMethod>(method);
            TransactionDescription? descriptionExpense = description != null ? new TransactionDescription(description) : null;

            return new Expense(
                money,
                expenseCategory,
                subCategoryExpense,
                transactionMethod,
                date,
                descriptionExpense,
                receipt
            );
        }
    }
}