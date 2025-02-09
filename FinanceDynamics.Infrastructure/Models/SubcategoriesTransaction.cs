using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class SubcategoriesTransaction
{
    public int Id { get; set; }

    public int TransactionCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual TransactionCategory TransactionCategory { get; set; } = null!;
}
