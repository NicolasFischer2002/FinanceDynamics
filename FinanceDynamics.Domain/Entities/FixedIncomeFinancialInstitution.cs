using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class FixedIncomeFinancialInstitution : FinancialInstitution
    {
        internal FixedIncomeFinancialInstitution(NameAndDescription nameAndDescription, string? code) 
            : base(nameAndDescription, code)
        {

        }
    }
}