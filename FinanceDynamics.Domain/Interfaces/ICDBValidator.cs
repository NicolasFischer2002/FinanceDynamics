namespace FinanceDynamics.Domain.Interfaces
{
    public interface ICDBValidator
    {
        void Validate(int investmentDuration);
        void ValidateInvestmentDuration(int investmentDuration);
    }
}