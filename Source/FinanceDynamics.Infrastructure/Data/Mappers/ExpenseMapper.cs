using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Helpers;
using FinanceDynamics.Domain.ValueObjects;
using FinanceDynamics.Infrastructure.Data.Entities;

namespace FinanceDynamics.Infrastructure.Data.Mappers
{
    internal static class ExpenseMapper
    {
        internal static Domain.Entities.Expense ToDomain(Entities.Expense expense)
        {
            var money = new Money((decimal)expense.Value);
            var date = expense.DateTime;
            var description = expense.Description is null
                ? new TransactionDescription(string.Empty)
                : new TransactionDescription(expense.Description);

            var expenseCategory = new ExpenseCategory(expense.Category);

            var expenseTransactionReceipt = expense.ExpenseTransactionReceipts.FirstOrDefault();
            var transactionReceipt = expenseTransactionReceipt is not null
                ? new TransactionReceipt(expenseTransactionReceipt.Name, expenseTransactionReceipt.File)
                : null;

            var domain = new Domain.Entities.Expense(
                money,
                expenseCategory,
                expense.Subcategory is not null ? new ExpenseSubcategory(expense.Subcategory, expenseCategory) : null,
                EnumHelper.GetValueFromName<TransactionMethod>(expense.Method),
                date,
                description,
                transactionReceipt
            );

            return domain;
        }

        internal static Entities.Expense ToData(Domain.Entities.Expense expense)
        {
            var receipts = new List<ExpenseTransactionReceipt>();

            if (expense.Receipt is not null)
            {
                receipts.Add(new ExpenseTransactionReceipt
                {
                    GuidId = expense.Id.ToString(),
                    Name = expense.Receipt.GetNameFile(),
                    File = expense.Receipt.GetFile()
                });
            }

            return new Entities.Expense
            {
                GuidId = expense.Id.ToString(),
                Value = (double)expense.Value.GetValue(),
                Category = expense.Category.Name,
                Subcategory = expense.Subcategory?.Name,
                Method = expense.Method.ToString(),
                DateTime = expense.Date,
                Description = expense.Description?.ToString(),
                ExpenseTransactionReceipts = receipts
            };
        }
    }
}