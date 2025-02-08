namespace FinanceDynamics.Domain.Interfaces
{
    public interface ICurrencyValidator
    {
        void Validate(string code, decimal exchange);
        void ValidateCode(string code);
        void ValidateExchangeRate(decimal exchange);
    }
}
