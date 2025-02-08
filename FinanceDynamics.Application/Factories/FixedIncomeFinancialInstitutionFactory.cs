using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Services;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class FixedIncomeFinancialInstitutionFactory : IFixedIncomeFinancialInstitutionFactory
    {
        private readonly IFinancialInstitutionValidator _financialInstitutionValidator;

        public FixedIncomeFinancialInstitutionFactory(IFinancialInstitutionValidator financialInstitutionValidator)
        {
            _financialInstitutionValidator = financialInstitutionValidator;
        }

        public FixedIncomeFinancialInstitution Create(NameAndDescription nameAndDescription, string? code)
        {
            _financialInstitutionValidator.Validate(code);

            return new FixedIncomeFinancialInstitution(nameAndDescription, code);
        }
    }
}