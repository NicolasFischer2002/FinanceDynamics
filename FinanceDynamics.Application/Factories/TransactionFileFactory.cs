using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class TransactionFileFactory : ITransactionFileFactory
    {
        private readonly ITransactionFileValidator _transactionFileValidator;

        public TransactionFileFactory(ITransactionFileValidator transactionFileValidator)
        {
            _transactionFileValidator = transactionFileValidator;
        }

        public TransactionFile Create(Guid transactionId, NameAndDescription nameAndDescription, byte[] file, DateTime date)
        {
            _transactionFileValidator.Validate(nameAndDescription, file, date);

            return new TransactionFile(transactionId, nameAndDescription, file, date);
        }
    }
}