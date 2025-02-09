using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class FinancialInstitution
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<FixedIncomeFinancialInstitution> FixedIncomeFinancialInstitutions { get; set; } = new List<FixedIncomeFinancialInstitution>();

    public virtual ICollection<VariableIncomeFinancialInstitution> VariableIncomeFinancialInstitutions { get; set; } = new List<VariableIncomeFinancialInstitution>();
}
