using System;
using System.Collections.Generic;

namespace FinanceDynamics.Infrastructure.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public int UserId { get; set; }

    public int TransactionCategoryId { get; set; }

    public int TransactionalMethodId { get; set; }

    public int CurrencyId { get; set; }

    public int TransactionStatusId { get; set; }

    public int TransactionTypeId { get; set; }

    public double Amount { get; set; }

    public string? Description { get; set; }

    public int Recurring { get; set; }

    public DateTime Date { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public virtual ICollection<Revenue> Revenues { get; set; } = new List<Revenue>();

    public virtual TransactionCategory TransactionCategory { get; set; } = null!;

    public virtual ICollection<TransactionFile> TransactionFiles { get; set; } = new List<TransactionFile>();

    public virtual TransactionStatus TransactionStatus { get; set; } = null!;

    public virtual TransactionType TransactionType { get; set; } = null!;

    public virtual TransactionalMethod TransactionalMethod { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
