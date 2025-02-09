using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<TransactionCategory> TransactionCategories { get; set; } = new List<TransactionCategory>();
}
