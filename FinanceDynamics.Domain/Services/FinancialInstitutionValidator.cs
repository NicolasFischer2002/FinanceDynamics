namespace FinanceDynamics.Domain.Services
{
    public class FinancialInstitutionValidator : IFinancialInstitutionValidator
    {
        private const int MaximumCodeLength = 10;

        public void Validate(string? code)
        {
            ValidateCode(code);
        }

        public void ValidateCode(string? code)
        {
            if (!string.IsNullOrWhiteSpace(code))
                if (code.Length > MaximumCodeLength)
                    throw new ArgumentException("O código da instituição financeira é inválido." +
                        $"O tamanho máximo para o código é de {MaximumCodeLength} caracteres.");
        }
    }
}