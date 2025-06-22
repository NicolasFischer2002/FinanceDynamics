using FinanceDynamics.Domain.Exceptions;
using System.Globalization;

namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record Money
    {
        public decimal Value { get; }

        public Money(decimal value)
        {
            ValidateValue(value);
            Value = value;
        }

        private void ValidateValue(decimal value)
        {
            const decimal MinimumValue = 0.01m;

            if (value < MinimumValue)
                throw new DomainException($"O valor da transação deve ser maior que R$ {MinimumValue}.", value.ToString());
        }

        public string GetFormattedValue()
        {
            return Value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public decimal GetValue()
        {
            return Value;
        }
    }
}