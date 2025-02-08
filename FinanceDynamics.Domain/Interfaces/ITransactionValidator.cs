namespace FinanceDynamics.Domain.Interfaces
{
    public interface ITransactionValidator
    {
        void Validate(decimal amount, string? description, DateTime date);
        void ValidateAmount(decimal amount);
        void ValidateDescription(string? description);
        void ValidateDate(DateTime date);
    }
}