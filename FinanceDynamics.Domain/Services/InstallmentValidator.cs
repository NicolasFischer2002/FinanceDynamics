using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class InstallmentValidator : IInstallmentValidator
    {
        /// <summary>
        /// Considering one installment per month, 1200 installments is equivalent to 100 years.
        /// </summary>
        private const int MaximumNumberOfInstallments = 1200;
        private const int MinimumNumberOfInstallments = 1;

        private const decimal MaximumValueForAInstallment = 1_000_000M;
        private const decimal MinimumValueForOneInstallment = 1;

        /// <summary>
        /// An installment can be due in a maximum of 100 years from the date of registration.
        /// </summary>
        private readonly DateTime MaximumDateForAnInstallment = DateTime.Now.AddYears(100);
        private readonly DateTime MinimumDateForAnInstallment = DateTime.Now;

        public void Validate(int number, decimal amount, DateTime dueDate)
        {
            ValidateNumber(number);
            ValidateAmount(amount);
            ValidadeDueDate(dueDate);
        }

        public void ValidateNumber(int number)
        {
            if (number < MinimumNumberOfInstallments || number > MaximumNumberOfInstallments)
                throw new ArgumentOutOfRangeException(nameof(number), $"Número de parcela informado é inválido. " +
                    $"O valor mínimo é de {MinimumNumberOfInstallments} e o valor máximo é de {MaximumNumberOfInstallments}.");
        }

        public void ValidateAmount(decimal amount)
        {
            if (amount < MinimumValueForOneInstallment || amount > MaximumValueForAInstallment)
                throw new ArgumentOutOfRangeException(nameof(amount), $"O valor informado é inválido. " +
                    $"O valor mínimo é de {MinimumValueForOneInstallment} e o valor máximo é de {MaximumValueForAInstallment}.");
        }

        public void ValidadeDueDate(DateTime dueDate)
        {
            if (dueDate < MinimumDateForAnInstallment || dueDate > MaximumDateForAnInstallment)
                throw new ArgumentOutOfRangeException(nameof(dueDate), $"A data de vencimento informada é inválida. " +
                    $"O data mínima é {MinimumDateForAnInstallment} e a data máxima é {MaximumDateForAnInstallment}.");
        }
    }
}