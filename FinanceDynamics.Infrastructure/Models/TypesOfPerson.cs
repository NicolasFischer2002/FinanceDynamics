using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class TypesOfPerson
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
