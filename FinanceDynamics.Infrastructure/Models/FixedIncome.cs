using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class FixedIncome
{
    public int Id { get; set; }

    public int InvestmentId { get; set; }

    public int FixedIncomeFinancialInstitutionsId { get; set; }

    public virtual ICollection<Cdb> Cdbs { get; set; } = new List<Cdb>();

    public virtual FixedIncomeFinancialInstitution FixedIncomeFinancialInstitutions { get; set; } = null!;

    public virtual Investment Investment { get; set; } = null!;
}
