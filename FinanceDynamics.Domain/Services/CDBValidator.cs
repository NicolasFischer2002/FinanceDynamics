using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class CDBValidator : ICDBValidator
    {
        /// <summary>
        /// 1200 months correspond to 100 years. 
        /// </summary>
        private const int MaximumInvestmentDuration = 1200;

        public void Validate(int investmentDuration)
        {
            ValidateInvestmentDuration(investmentDuration);
        }

        public void ValidateInvestmentDuration(int investmentDuration)
        {
            if (investmentDuration > MaximumInvestmentDuration)
                throw new ArgumentException("A quantidade de tempo informada para o investimento é inválida." +
                    $"O limite de tempo é de {MaximumInvestmentDuration} meses.");
        }
    }
}