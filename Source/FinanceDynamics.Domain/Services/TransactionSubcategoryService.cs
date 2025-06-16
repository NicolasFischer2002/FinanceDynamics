using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;
using System.Reflection;

namespace FinanceDynamics.Domain.Services
{
    public class TransactionSubcategoryService : ITransactionSubcategoryService
    {
        public IEnumerable<string> GetSubcategories(TransactionKind kind, string categoryName)
        {
            var subType = kind == TransactionKind.Expense
                ? typeof(ExpenseSubcategory)
                : typeof(IncomeSubcategory);

            var fields = subType.GetFields(
                BindingFlags.Public |
                BindingFlags.Static
            ).Where(f => f.FieldType == subType);

            foreach (var f in fields)
            {
                var instance = f.GetValue(null)!;
                var parentProp = subType.GetProperty("Parent")!;
                var nameProp = subType.GetProperty("Name")!;

                var parent = (TransactionCategory)parentProp.GetValue(instance)!;
                if (parent.Name != categoryName)
                    continue;

                var name = (string)nameProp.GetValue(instance)!;
                yield return name;
            }
        }
    }
}