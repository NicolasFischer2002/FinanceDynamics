using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class InvestmentValidator : IInvestmentValidator
    {
        private const int MinimumValue = 1;
        private const int MinimumTransactionFee = 0;
        private const int MaximumDescriptionLength = 100;
        private readonly DateTime MinimumDate = DateTime.Now;

        public void Validate(decimal value, decimal transactionFee, string? description, DateTime date)
        {
            ValidateValue(value);
            ValidateTransactionFee(transactionFee);
            ValidateDescription(description);
            ValidateDate(date);
        }

        public void ValidateValue(decimal value)
        {
            if (value < MinimumValue)
                throw new ArgumentException($"O valor informado [{value}] para o investimento é inválido." +
                    $"O valor mínimo é de {MinimumValue}.");
        }

        public void ValidateTransactionFee(decimal transactionFee)
        {
            if (transactionFee < MinimumTransactionFee)
                throw new ArgumentException($"O valor informado [{transactionFee}] para taxa de transação é inválido." +
                    $"O valor mínimo é de {transactionFee}.");
        }

        public void ValidateDescription(string? description)
        {
            if (!string.IsNullOrWhiteSpace(description))
                if (description.Length > MaximumDescriptionLength)
                    throw new ArgumentException($"A descrição informado excede o limite de caracteres máximo." +
                        $"O limite máximo é de {MaximumDescriptionLength}.");
        }

        /// <summary>
        /// An investment with a date prior to the current one can be created. 
        /// The system should allow users to create investments that are ongoing, 
        /// that is, that are already in progress and are not being created at the present time.
        /// </summary>
        /// <param name="date"></param>
        public void ValidateDate(DateTime date)
        {
            if (date < MinimumDate)
                throw new ArgumentException("A data informada é inválida.");
        }
    }
}