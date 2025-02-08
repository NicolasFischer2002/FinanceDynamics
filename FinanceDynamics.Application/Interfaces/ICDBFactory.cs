using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ICDBFactory
    {
        CDB Create(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date,
            FixedIncomeFinancialInstitution fixedIncomeFinancialInstitution,
            bool immediateWithdrawal, int investmentDuration);
    }
}