using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class TransactionStatus
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
