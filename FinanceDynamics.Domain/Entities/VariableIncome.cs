
namespace FinanceDynamics.Domain.Entities
{
    public abstract class VariableIncome : Investment
    {
        public VariableIncomeFinancialInstitution VariableIncomeFinancialInstitution { get; private set; }

        internal VariableIncome(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date,
            VariableIncomeFinancialInstitution variableIncomeFinancialInstitution) 
            : base(userId, value, transactionFee, description, date)
        {
            VariableIncomeFinancialInstitution = variableIncomeFinancialInstitution;
        }
    }
}