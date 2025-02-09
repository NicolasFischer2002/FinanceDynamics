using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Currency
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Code { get; set; } = null!;

    public double ExchangeRateToUsd { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
