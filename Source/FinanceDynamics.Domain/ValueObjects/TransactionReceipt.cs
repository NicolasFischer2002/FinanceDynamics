namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record TransactionReceipt
    {
        private string Name { get; set; }
        private byte[] File { get; set; }
        public long SizeInBytes => File.LongLength;

        public TransactionReceipt(string name, byte[] file)
        {
            Name = name;
            File = file;
        }
    }
}