using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class TransactionCategory
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<SubcategoriesTransaction> SubcategoriesTransactions { get; set; } = new List<SubcategoriesTransaction>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
