using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class Income : Transaction<IncomeCategory, IncomeSubcategory>
    {
        public Income(
            Money value,
            IncomeCategory category,
            IncomeSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null)
            : base(value, category, subcategory, method, date, description, receipt)
        {

        }
    }
}