using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class VariableIncome
{
    public int Id { get; set; }

    public int InvestmentId { get; set; }

    public int VariableIncomeFinancialInstitutionId { get; set; }

    public virtual Investment Investment { get; set; } = null!;

    public virtual ICollection<Share> Shares { get; set; } = new List<Share>();

    public virtual VariableIncomeFinancialInstitution VariableIncomeFinancialInstitution { get; set; } = null!;
}
