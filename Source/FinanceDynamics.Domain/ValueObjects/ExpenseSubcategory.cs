namespace FinanceDynamics.Domain.ValueObjects
{
    public sealed record ExpenseSubcategory : SubcategoryTransaction<ExpenseCategory>
    {
        public static readonly ExpenseSubcategory Meal = new("Refeição", ExpenseCategory.Food);
        public static readonly ExpenseSubcategory Supermarket = new("Supermercado", ExpenseCategory.Food);
        public static readonly ExpenseSubcategory EatingOut = new("Comer Fora", ExpenseCategory.Food);

        public static readonly ExpenseSubcategory Electricity = new("Energia/Luz", ExpenseCategory.BillsAndServices);
        public static readonly ExpenseSubcategory Water = new("Água", ExpenseCategory.BillsAndServices);
        public static readonly ExpenseSubcategory Internet = new("Internet", ExpenseCategory.BillsAndServices);

        public static readonly ExpenseSubcategory CollegeTuition = new("Mensalidade Curso Superior", ExpenseCategory.Education);
        public static readonly ExpenseSubcategory Books = new("Livro(s)", ExpenseCategory.Education);
        public static readonly ExpenseSubcategory Course = new("Curso", ExpenseCategory.Education);

        public static readonly ExpenseSubcategory IPVA = new("IPVA", ExpenseCategory.Taxes);
        public static readonly ExpenseSubcategory Licensing = new("Licenciamento", ExpenseCategory.Taxes);
        public static readonly ExpenseSubcategory IPTU = new("IPTU", ExpenseCategory.Taxes);
        public static readonly ExpenseSubcategory IncomeTax = new("Imposto de Renda", ExpenseCategory.Taxes);

        public static readonly ExpenseSubcategory YoutubePremium = new("Youtube Premium", ExpenseCategory.LeisureEntertainment);
        public static readonly ExpenseSubcategory Cinema = new("Cinema", ExpenseCategory.LeisureEntertainment);

        public static readonly ExpenseSubcategory FinancingInstallment = new("Parcela Financiamento", ExpenseCategory.Housing);
        public static readonly ExpenseSubcategory Rent = new("Aluguel", ExpenseCategory.Housing);

        public static readonly ExpenseSubcategory Pharmacy = new("Farmácia", ExpenseCategory.Health);
        public static readonly ExpenseSubcategory MedicalConsultation = new("Consulta Médica", ExpenseCategory.Health);

        public static readonly ExpenseSubcategory LifeInsurance = new("Seguro de Vida", ExpenseCategory.Insurance);
        public static readonly ExpenseSubcategory VehicleInsurance = new("Seguro Veicular", ExpenseCategory.Insurance);
        public static readonly ExpenseSubcategory HomeInsurance = new("Seguro Residencial", ExpenseCategory.Insurance);

        public static readonly ExpenseSubcategory PublicTransportation = new ("Transporte público", ExpenseCategory.Transport);
        public static readonly ExpenseSubcategory TransportOwnVehicle = new("Veículo próprio", ExpenseCategory.Transport);

        public static readonly ExpenseSubcategory Clothing = new("Roupas", ExpenseCategory.ClothingAndFootwear);
        public static readonly ExpenseSubcategory Footwear = new("Calçados", ExpenseCategory.ClothingAndFootwear);

        public ExpenseSubcategory(string name, ExpenseCategory parent)
            : base(name, parent)
        {

        }
    }
}