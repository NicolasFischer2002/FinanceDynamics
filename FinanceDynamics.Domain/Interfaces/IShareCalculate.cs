namespace FinanceDynamics.Domain.Interfaces
{
    public interface IShareCalculate
    {
        decimal PricePerUnit(decimal totalValue, int quantity);
    }
}