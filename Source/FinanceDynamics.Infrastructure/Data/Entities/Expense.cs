using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Data.Entities;

public partial class Expense
{
    public int Id { get; set; }

    public string GuidId { get; set; } = null!;

    public double Value { get; set; }

    public string Category { get; set; } = null!;

    public string? Subcategory { get; set; }

    public string Method { get; set; } = null!;

    public string DateTime { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<ExpenseTransactionReceipt> ExpenseTransactionReceipts { get; set; } = new List<ExpenseTransactionReceipt>();
}
