namespace FinanceDynamics.Domain.Entities
{
    public class Share : VariableIncome
    {
        public int Quantity { get; private set; }
        public decimal PricePerUnit { get; private set; }
        public string Symbol { get; private set; }
        public string Company { get; private set; }

        internal Share(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date,
            VariableIncomeFinancialInstitution variableIncomeFinancialInstitution,
            int quantity, decimal pricePerUnit, string symbol, string company)
            : base(userId, value, transactionFee, description, date, variableIncomeFinancialInstitution)
        {
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
            Symbol = symbol;
            Company = company;
        }
    }
}