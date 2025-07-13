using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Data.Entities;

public partial class ExpenseTransactionReceipt
{
    public int Id { get; set; }

    public string GuidId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[] File { get; set; } = null!;

    public virtual Expense Guid { get; set; } = null!;
}
