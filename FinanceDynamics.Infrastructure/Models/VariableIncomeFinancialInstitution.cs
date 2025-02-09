using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class VariableIncomeFinancialInstitution
{
    public int Id { get; set; }

    public int FinancialInstitutionId { get; set; }

    public virtual FinancialInstitution FinancialInstitution { get; set; } = null!;

    public virtual ICollection<VariableIncome> VariableIncomes { get; set; } = new List<VariableIncome>();
}
