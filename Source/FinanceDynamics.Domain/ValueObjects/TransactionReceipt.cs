using FinanceDynamics.Domain.Exceptions;

namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record TransactionReceipt
    {
        private string Name { get; set; }
        private byte[] File { get; set; }
        private string Extension { get; set; }
        public long SizeInBytes => File.LongLength;
        private readonly string[] ValidExtensions = [".pdf", ".png", ".jpg", ".jpeg"];

        public TransactionReceipt(string name, byte[] file)
        {
            name = name.Trim();
            ValidateName(name);

            Extension = Path.GetExtension(name).ToLower();
            ValidateExtension(Extension);
            ValidateSizeInBytes(file);

            Name = name;
            File = file;
        }

        private void ValidateName(string name)
        {
            const int maximumLength = 100;

            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException($"O nome do arquivo não pode ser nulo ou vazio.", name);

            if (name.Length > maximumLength)
                throw new DomainException($"O nome do arquivo não pode exceder {maximumLength} caracteres.", name);
        }

        private void ValidateExtension(string extension)
        {
            if (!ValidExtensions.Contains(extension))
                throw new DomainException($"A extensão do arquivo [{extension}] é inválida.", extension);
        }

        private void ValidateSizeInBytes(byte[] file)
        {
            const long maxFileSizeInBytes = 5 * 1024 * 1024; // 5 MB

            if (file.Length == 0)
                throw new DomainException("O arquivo não pode ser nulo ou vazio.", "Arquivo da transação");

            if (file.Length > maxFileSizeInBytes)
                throw new DomainException(
                    $"O arquivo não pode exceder {maxFileSizeInBytes / (1024 * 1024)} MB.",
                    "Arquivo da transação"
                );
        }

        public string GetNameFile()
        {
            return Name;
        }

        public byte[] GetFile()
        {
            return File;
        }

        public string GetExtension() 
        {
            return Extension;
        }
    }
}