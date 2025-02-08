namespace FinanceDynamics.Domain.Services
{
    public interface IFinancialInstitutionValidator
    {
        void Validate(string? code);
        void ValidateCode(string? code);
    }
}