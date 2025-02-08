
namespace FinanceDynamics.Domain.Entities
{
    public abstract class FixedIncome : Investment
    {
        public FixedIncomeFinancialInstitution FixedIncomeFinancialInstitution { get; private set; }

        internal FixedIncome(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date,
            FixedIncomeFinancialInstitution fixedIncomeFinancialInstitution) 
            : base(userId, value, transactionFee, description, date)
        {
            FixedIncomeFinancialInstitution = fixedIncomeFinancialInstitution;
        }
    }
}