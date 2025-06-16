using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;
using System.Reflection;

namespace FinanceDynamics.Domain.Services
{
    public class TransactionCategoryService : ITransactionCategoryService
    {
        public IEnumerable<string> GetCategories(TransactionKind kind)
        {
            var type = kind == TransactionKind.Expense
                ? typeof(ExpenseCategory)
                : typeof(IncomeCategory);

            return type
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.FieldType == type)
                .Select(f => ((TransactionCategory)f.GetValue(null)!).Name);
        }
    }
}