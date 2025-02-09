using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Cdb
{
    public int Id { get; set; }

    public int FixedIncomeId { get; set; }

    public int ImmediateWithdrawal { get; set; }

    public int InvestmentDuration { get; set; }

    public virtual FixedIncome FixedIncome { get; set; } = null!;
}
