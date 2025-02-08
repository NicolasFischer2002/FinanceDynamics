using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class Currency : BaseEntity
    {
        public NameAndDescription NameAndDescription { get; private set; }
        public string Code { get; private set; }
        public decimal ExchangeRateToUSD { get; private set; }

        internal Currency(NameAndDescription nameAndDescription, string code, decimal exchangeRateToUSD)
        {
            NameAndDescription = nameAndDescription;
            Code = code;
            ExchangeRateToUSD = exchangeRateToUSD;
        }
    }
}