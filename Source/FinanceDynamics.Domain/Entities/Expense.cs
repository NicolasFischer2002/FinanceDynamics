using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class Expense : Transaction<ExpenseCategory, ExpenseSubcategory>
    {
        public Expense(
            Money value,
            ExpenseCategory category,
            ExpenseSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null)
            : base(value, category, subcategory, method, date, description, receipt)
        {

        }
    }
}