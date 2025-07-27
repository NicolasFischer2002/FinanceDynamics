using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IExpenseFactory
    {
        Expense Create(
            Money value,
            ExpenseCategory category,
            ExpenseSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null
        );

        Expense Create(
            decimal value,
            string category,
            string? subcategory,
            string method,
            DateTime date,
            string? description = null,
            TransactionReceipt? receipt = null
        );
    }
}