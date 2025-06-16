namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record ExpenseCategory : TransactionCategory
    {
        public static readonly ExpenseCategory Food = new("Alimentação");
        public static readonly ExpenseCategory BillsAndServices = new("Contas e Serviços");
        public static readonly ExpenseCategory Education = new("Educação");
        public static readonly ExpenseCategory Taxes = new("Impostos");
        public static readonly ExpenseCategory LeisureEntertainment = new("Lazer e Entretenimento");
        public static readonly ExpenseCategory Housing = new("Moradia");
        public static readonly ExpenseCategory Health = new("Saúde");
        public static readonly ExpenseCategory Insurance = new("Seguros");
        public static readonly ExpenseCategory ClothingAndFootwear = new("Vestuário e Calçados");
        public static readonly ExpenseCategory Others = new("Outros");

        public ExpenseCategory(string name)
            : base(name)
        {

        }
    }
}