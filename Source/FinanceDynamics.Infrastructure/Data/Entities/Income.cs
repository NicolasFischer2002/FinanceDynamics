namespace FinanceDynamics.Infrastructure.Data.Entities;

public partial class Income
{
    public int Id { get; set; }

    public string GuidId { get; set; } = null!;

    public double Value { get; set; }

    public string Category { get; set; } = null!;

    public string? Subcategory { get; set; }

    public string Method { get; set; } = null!;

    public DateTime DateTime { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<IncomeTransactionReceipt> IncomeTransactionReceipts { get; set; } = new List<IncomeTransactionReceipt>();
}
