using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Investment
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public int PersonId { get; set; }

    public double Value { get; set; }

    public double TransactionFee { get; set; }

    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public int InvestmentTypeId { get; set; }

    public virtual ICollection<FixedIncome> FixedIncomes { get; set; } = new List<FixedIncome>();

    public virtual InvestmentType InvestmentType { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<VariableIncome> VariableIncomes { get; set; } = new List<VariableIncome>();
}
