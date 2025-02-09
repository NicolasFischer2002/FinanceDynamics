using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class TransactionalMethod
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
