using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class TransactionValidator : ITransactionValidator
    {
        private const int MinimumAmount = 1;
        private const int MaximumDescriptionLength = 100;
        private readonly DateTime MinimumDate = DateTime.Now;

        public void Validate(decimal amount, string? description, DateTime date)
        {
            ValidateAmount(amount);
            ValidateDescription(description);
            ValidateDate(date);
        }

        public void ValidateAmount(decimal amount)
        {
            if (amount < MinimumAmount)
                throw new ArgumentOutOfRangeException(nameof(amount), $"O valor informado [{amount}]" +
                    $"não é válido. O valor mínimo aceitável é de {MinimumAmount}.");
        }

        public void ValidateDescription(string? description)
        {
            if (!string.IsNullOrWhiteSpace(description))
                if (description.Length > MaximumDescriptionLength)
                    throw new ArgumentOutOfRangeException(nameof(description), $"A descrição informada é inválida." +
                        $"O comprimento máximo para a descrição é de {MaximumDescriptionLength} caracteres.");
        }

        public void ValidateDate(DateTime date)
        {
            if (date < MinimumDate)
                throw new ArgumentOutOfRangeException(nameof(date), $"A data informada é inválida.");
        }
    }
}