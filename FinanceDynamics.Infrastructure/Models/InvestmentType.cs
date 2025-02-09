using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class InvestmentType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Investment> Investments { get; set; } = new List<Investment>();
}
