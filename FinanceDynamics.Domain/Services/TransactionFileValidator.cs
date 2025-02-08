using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Services
{
    public class TransactionFileValidator : ITransactionFileValidator
    {
        /// <summary>
        /// The maximum file size allowed for upload, in bytes.
        /// This value is set to 5 MB, which is equivalent to 5,242,880 bytes.
        /// </summary>
        private const long MaximumFileSizeInBytes = 5242880;

        private readonly DateTime MaximumDate = DateTime.Now.AddYears(100);
        private readonly DateTime MinimumDate = DateTime.Now;
        
        public void Validate(NameAndDescription nameAndDescription, byte[] file, DateTime date)
        {
            ValidateFile(file);
            ValidadeDate(date);
        }

        public void ValidateFile(byte[] file)
        {
            if (file.Length > MaximumFileSizeInBytes)
                throw new ArgumentOutOfRangeException(nameof(file), $"O arquivo excede ao tamanho máximo " +
                    $"permitido de {MaximumFileSizeInBytes} bytes.");
        }

        public void ValidadeDate(DateTime date)
        {
            if (date < MinimumDate || date > MaximumDate)
                throw new ArgumentOutOfRangeException(nameof(date), $"Data informada inválida.");
        }
    }
}