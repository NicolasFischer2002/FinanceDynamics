using FinanceDynamics.Infrastructure.Data.Entities;

namespace FinanceDynamics.Infrastructure.Data.Mappers
{
    internal static class TransactionReceiptMapper
    {
        internal static Domain.ValueObjects.TransactionReceipt ToDomain(ExpenseTransactionReceipt expenseTransactionReceipt)
        {
            return new Domain.ValueObjects.TransactionReceipt(
                expenseTransactionReceipt.Name, 
                expenseTransactionReceipt.File
            );
        }

        internal static Domain.ValueObjects.TransactionReceipt ToDomain(IncomeTransactionReceipt expenseTransactionReceipt)
        {
            return new Domain.ValueObjects.TransactionReceipt(
                expenseTransactionReceipt.Name,
                expenseTransactionReceipt.File
            );
        }

        internal static IncomeTransactionReceipt ToDataIncome(Domain.ValueObjects.TransactionReceipt transactionReceipt, string idTransaction)
        {
            IncomeTransactionReceipt incomeTransactionReceipt = new IncomeTransactionReceipt();
            incomeTransactionReceipt.GuidId = idTransaction;
            incomeTransactionReceipt.Name = transactionReceipt.GetNameFile();
            incomeTransactionReceipt.File = transactionReceipt.GetFile();

            return incomeTransactionReceipt;
        }

        internal static ExpenseTransactionReceipt ToDataExpense(Domain.ValueObjects.TransactionReceipt transactionReceipt, string idTransaction)
        {
            ExpenseTransactionReceipt expenseTransactionReceipt = new ExpenseTransactionReceipt();
            expenseTransactionReceipt.GuidId = idTransaction;
            expenseTransactionReceipt.Name = transactionReceipt.GetNameFile();
            expenseTransactionReceipt.File = transactionReceipt.GetFile();

            return expenseTransactionReceipt;
        }
    }
}