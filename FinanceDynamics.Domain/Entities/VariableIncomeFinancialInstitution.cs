using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class VariableIncomeFinancialInstitution : FinancialInstitution
    {
        internal VariableIncomeFinancialInstitution(NameAndDescription nameAndDescription, string? code) 
            : base(nameAndDescription, code)
        {

        }
    }
}