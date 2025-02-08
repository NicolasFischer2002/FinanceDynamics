namespace FinanceDynamics.Domain.ValueObjects
{
    public class TransactionFile
    {
        public Guid TransactionId { get; private set; }
        public NameAndDescription NameAndDescription { get; private set; }
        public byte[] File { get; private set; }
        public DateTime Date { get; private set; }

        internal TransactionFile(Guid transactionId, NameAndDescription nameAndDescription, byte[] file, DateTime date)
        {
            TransactionId = transactionId;
            NameAndDescription = nameAndDescription;
            File = file;
            Date = date;
        }
    }
}