namespace FinanceDynamics.Domain.Interfaces
{
    public interface IInstallmentValidator
    {
        void Validate(int number, decimal amount, DateTime dueDate);
        void ValidateNumber(int number);
        void ValidateAmount(decimal amount);
        void ValidadeDueDate(DateTime dueDate);
    }
}