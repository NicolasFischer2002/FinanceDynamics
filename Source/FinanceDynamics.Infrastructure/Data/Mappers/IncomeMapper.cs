using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Helpers;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Infrastructure.Data.Mappers
{
    public static class IncomeMapper
    {
        public static Domain.Entities.Income ToDomain(Infrastructure.Data.Entities.Income income)
        {
            var money = new Money((decimal)income.Value);
            var date = DateTime.Parse(income.DateTime);
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
    }
}