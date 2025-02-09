using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Expense
{
    public int Id { get; set; }

    public int TransactionId { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? PaymentDate { get; set; }

    public int? PaidLate { get; set; }

    public virtual Transaction Transaction { get; set; } = null!;
}
