using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Revenue
{
    public int Id { get; set; }

    public int TransactionId { get; set; }

    public DateTime? DateOfReceipt { get; set; }

    public int? ReceivedLate { get; set; }

    public virtual Transaction Transaction { get; set; } = null!;
}
