namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record IncomeSubcategory : SubcategoryTransaction<IncomeCategory>
    {
        public static readonly IncomeSubcategory BaseSalary = new("Salário base", IncomeCategory.Salary);
        public static readonly IncomeSubcategory Overtime = new("Horas extras", IncomeCategory.Salary);
        public static readonly IncomeSubcategory Bonus = new("Bonificação", IncomeCategory.Salary);

        public IncomeSubcategory(string name, IncomeCategory parent)
            : base(name, parent)
        {

        }
    }
}