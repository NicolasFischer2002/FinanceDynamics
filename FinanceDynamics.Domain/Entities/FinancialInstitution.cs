using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public abstract class FinancialInstitution
    {
        public NameAndDescription NameAndDescription { get; private set; }
        public string? Code { get; private set; }

        protected FinancialInstitution(NameAndDescription nameAndDescription, string? code)
        {
            NameAndDescription = nameAndDescription;
            Code = code;
        }
    }
}