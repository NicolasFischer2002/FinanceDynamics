namespace FinanceDynamics.Domain.ValueObjects
{
    public record Password
    {
        public string Value { get; private set; }

        internal Password(string value)
        {
            Value = value;
        }
    }
}
