namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed class TransactionDescription
    {
        private string Description { get; set; }

        public TransactionDescription(string description)
        {
            Description = description;
        }

        public override string ToString() 
        {
            return Description;
        }
    }
}