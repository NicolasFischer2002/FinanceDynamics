namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record IncomeCategory : TransactionCategory
    {
        public static readonly IncomeCategory Gift = new("Presente");
        public static readonly IncomeCategory Salary = new("Salário");
        public static readonly IncomeCategory Reimbursement = new("Reembolso");
        public static readonly IncomeCategory Other = new("Outro");

        public IncomeCategory(string name)
            : base(name)
        {
        }
    }
}