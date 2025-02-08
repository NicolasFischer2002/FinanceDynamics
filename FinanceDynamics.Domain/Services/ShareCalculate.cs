using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class ShareCalculate : IShareCalculate
    {
        public decimal PricePerUnit(decimal totalValue, int quantity)
        {
            return totalValue / quantity;
        }
    }
}