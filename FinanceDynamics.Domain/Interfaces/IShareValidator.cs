namespace FinanceDynamics.Domain.Interfaces
{
    public interface IShareValidator
    {
        void Validate(int quantity, decimal pricePerUnit, string symbol, string company);
        void ValidateQuantity(int quantity);
        void ValidatePricePerUnit(decimal pricePerUnit);
        void ValidateSymbol(string symbol);
        void ValidateCompany(string company);
    }
}