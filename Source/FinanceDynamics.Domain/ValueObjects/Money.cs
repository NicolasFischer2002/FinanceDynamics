namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed class Money
    {
        private decimal Value { get; set; }

        public Money(decimal value)
        {
            Value = value;
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