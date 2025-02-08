using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IVariableIncomeFinancialInstitutionFactory
    {
        VariableIncomeFinancialInstitution Create(NameAndDescription nameAndDescription, string? code);
    }
}