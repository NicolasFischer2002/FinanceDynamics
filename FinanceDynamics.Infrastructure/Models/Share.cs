using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Share
{
    public int Id { get; set; }

    public int VariableIncomeId { get; set; }

    public int Quantity { get; set; }

    public double PricePerUnit { get; set; }

    public string Symbol { get; set; } = null!;

    public string Company { get; set; } = null!;

    public virtual VariableIncome VariableIncome { get; set; } = null!;
}
