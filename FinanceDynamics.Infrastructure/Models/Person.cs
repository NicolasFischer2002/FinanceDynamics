using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int TypeOfPersonId { get; set; }

    public virtual ICollection<Investment> Investments { get; set; } = new List<Investment>();

    public virtual TypesOfPerson TypeOfPerson { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
