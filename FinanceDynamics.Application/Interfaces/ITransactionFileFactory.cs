using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ITransactionFileFactory
    {
        TransactionFile Create(Guid transactionId, NameAndDescription nameAndDescription, byte[] file, DateTime date);
    }
}