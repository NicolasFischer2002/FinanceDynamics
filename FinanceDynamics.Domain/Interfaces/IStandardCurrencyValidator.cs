namespace FinanceDynamics.Domain.Interfaces
{
    public interface IStandardCurrencyValidator
    {
        void ValidateName(string name);
        void ValidateCode(string code);
        void ValidateConversionRate(decimal conversionRate);
    }
}
