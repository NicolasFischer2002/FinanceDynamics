using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Helpers;
using FinanceDynamics.Domain.ValueObjects;
using FinanceDynamics.Infrastructure.Data.Entities;

namespace FinanceDynamics.Infrastructure.Data.Mappers
{
    internal static class IncomeMapper
    {
        internal static Domain.Entities.Income ToDomain(Entities.Income income)
        {
            var money = new Money((decimal)income.Value);
            var date = income.DateTime;
            var description = income.Description is null
                ? new TransactionDescription(string.Empty)
                : new TransactionDescription(income.Description);

            var incomeCategory = new IncomeCategory(income.Category);

            var incomeTransactionReceipt = income.IncomeTransactionReceipts.FirstOrDefault();
            var transactionReceipt = incomeTransactionReceipt is not null
                ? new TransactionReceipt(incomeTransactionReceipt.Name, incomeTransactionReceipt.File)
                : null;

            var domain = new Domain.Entities.Income(
                money,
                incomeCategory,
                income.Subcategory is not null ? new IncomeSubcategory(income.Subcategory, incomeCategory) : null,
                EnumHelper.GetValueFromName<TransactionMethod>(income.Method),
                date,
                description,
                transactionReceipt
            );

            return domain;
        }

        internal static Entities.Income ToData(Domain.Entities.Income income)
        {
            var receipts = new List<IncomeTransactionReceipt>();

            if (income.Receipt is not null)
            {
                receipts.Add(new IncomeTransactionReceipt
                {
                    GuidId = income.Id.ToString(),
                    Name = income.Receipt.GetNameFile(),
                    File = income.Receipt.GetFile()
                });
            }

            return new Entities.Income
            {
                GuidId = income.Id.ToString(),
                Value = (double)income.Value.GetValue(),
                Category = income.Category.Name,         
                Subcategory = income.Subcategory?.Name,
                Method = income.Method.ToString(),
                DateTime = income.Date,
                Description = income.Description?.ToString(),
                IncomeTransactionReceipts = receipts
            };
        }
    }
}