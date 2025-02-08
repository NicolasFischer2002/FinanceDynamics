
namespace FinanceDynamics.Domain.Entities
{
    public class CDB : FixedIncome
    {
        public bool ImmediateWithdrawal { get; private set; }

        /// <summary>
        /// It should be measured in months.
        /// </summary>
        public int InvestmentDuration { get; private set; }

        internal CDB(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date, 
            FixedIncomeFinancialInstitution fixedIncomeFinancialInstitution, 
            bool immediateWithdrawal, int investmentDuration) 
            : base(userId, value, transactionFee, description, date, fixedIncomeFinancialInstitution)
        {
            ImmediateWithdrawal = immediateWithdrawal;
            InvestmentDuration = investmentDuration;
        }
    }
}