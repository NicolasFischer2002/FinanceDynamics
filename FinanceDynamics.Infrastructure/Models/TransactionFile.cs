using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class TransactionFile
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public int TransactionId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public byte[] File { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual Transaction Transaction { get; set; } = null!;
}
