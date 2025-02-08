using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Services;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class VariableIncomeFinancialInstitutionFactory : IVariableIncomeFinancialInstitutionFactory
    {
        private readonly IFinancialInstitutionValidator _financialInstitutionValidator;

        public VariableIncomeFinancialInstitutionFactory(IFinancialInstitutionValidator financialInstitutionValidator)
        {
            _financialInstitutionValidator = financialInstitutionValidator;
        }

        public VariableIncomeFinancialInstitution Create(NameAndDescription nameAndDescription, string? code)
        {
            _financialInstitutionValidator.Validate(code);

            return new VariableIncomeFinancialInstitution(nameAndDescription, code);
        }
    }
}