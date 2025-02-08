using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class ShareValidator : IShareValidator
    {
        private const int MinimumQuantity = 1;
        private const int MaximumQuantity = 100_000;

        private const int MinimumPriceperUnit = 1;
        private const int MaximumPriceperUnit = 10_000;

        private const int MinimumSymbolLength = 1;
        private const int MaximumSymbolLength = 5;

        private const int MinimumCompanyLength = 1;
        private const int MaximumCompanyLength = 150;

        public void Validate(int quantity, decimal pricePerUnit, string symbol, string company)
        {
            ValidateQuantity(quantity);
            ValidatePricePerUnit(pricePerUnit);
            ValidateSymbol(symbol);
            ValidateCompany(company);
        }

        public void ValidateQuantity(int quantity)
        {
            if (quantity < MinimumQuantity || quantity > MaximumQuantity)
                throw new ArgumentOutOfRangeException(nameof(quantity), "A quantidade de ativos informada é inválida. " +
                    $"O valor mínimo permitido é de {MinimumQuantity}, e o valor máximo é de {MaximumQuantity}.");
        }

        public void ValidatePricePerUnit(decimal pricePerUnit)
        {
            if (pricePerUnit < MinimumPriceperUnit || pricePerUnit > MaximumPriceperUnit)
                throw new ArgumentOutOfRangeException(nameof(pricePerUnit), "O valor pago por ativo é inválido. " +
                    $"O valor mínimo permitido é de {MinimumPriceperUnit}, e o valor máximo é de {MaximumPriceperUnit}.");
        }

        public void ValidateSymbol(string symbol)
        {
            if (symbol.Length < MinimumSymbolLength || symbol.Length > MaximumSymbolLength)
                throw new ArgumentOutOfRangeException(nameof(symbol), "O código informado para o ativo é inválido. " +
                    $"Para ser considerado válido, o código deve possui entre {MinimumSymbolLength} e " +
                    $"{MaximumSymbolLength} caracteres.");
        }

        public void ValidateCompany(string company)
        {
            if (company.Length < MinimumCompanyLength || company.Length > MaximumCompanyLength)
                throw new ArgumentOutOfRangeException(nameof(company), "A empresa informada é inválida." +
                    $"Para ser considerada válida, a empresa deve possui entre {MinimumCompanyLength} e " +
                    $"{MaximumCompanyLength} caracteres.");
        }
    }
}