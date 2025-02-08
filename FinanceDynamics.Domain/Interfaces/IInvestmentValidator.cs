namespace FinanceDynamics.Domain.Interfaces
{
    public interface IInvestmentValidator
    {
        void Validate(decimal value, decimal transactionFee, string? description, DateTime date);
        void ValidateValue(decimal value);
        void ValidateTransactionFee(decimal transactionFee);
        void ValidateDescription(string? description);
        void ValidateDate(DateTime date);
    }
}