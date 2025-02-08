using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Interfaces
{
    public interface ITransactionFileValidator
    {
        void Validate(NameAndDescription nameAndDescription, byte[] file, DateTime date);
        void ValidateFile(byte[] file);
        void ValidadeDate(DateTime date);
    }
}
