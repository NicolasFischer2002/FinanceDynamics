using FinanceDynamics.Domain.Exceptions;

namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed class TransactionDescription
    {
        private string Description { get; set; }

        public TransactionDescription(string description)
        {
            description = description.Trim();
            ValidateDescription(description);
            Description = description;
        }

        private void ValidateDescription(string description)
        {
            const int maximumLength = 70;

            if (!string.IsNullOrWhiteSpace(description))
                if (description.Length > maximumLength)
                    throw new DomainException($"A descrição deve possuir até {maximumLength} caracteres.", description);
        }

        public override string ToString() 
        {
            return Description;
        }
    }
}