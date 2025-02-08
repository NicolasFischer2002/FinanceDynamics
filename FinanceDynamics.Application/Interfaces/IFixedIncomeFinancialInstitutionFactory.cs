using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IFixedIncomeFinancialInstitutionFactory
    {
        FixedIncomeFinancialInstitution Create(NameAndDescription nameAndDescription, string? code);
    }
}