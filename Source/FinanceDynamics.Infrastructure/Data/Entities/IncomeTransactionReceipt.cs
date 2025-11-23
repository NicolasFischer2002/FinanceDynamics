namespace FinanceDynamics.Infrastructure.Data.Entities;

public partial class IncomeTransactionReceipt
{
    public int Id { get; set; }

    public string GuidId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[] File { get; set; } = null!;

    public virtual Income Guid { get; set; } = null!;
}
