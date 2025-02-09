using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class User
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public int StandardCurrencyId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Currency StandardCurrency { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
