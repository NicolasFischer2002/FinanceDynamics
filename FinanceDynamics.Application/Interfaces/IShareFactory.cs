using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IShareFactory
    {
        Share Create(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date,
            VariableIncomeFinancialInstitution variableIncomeFinancialInstitution,
            int quantity, string symbol, string company);
    }
}