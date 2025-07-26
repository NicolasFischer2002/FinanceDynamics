using FinanceDynamics.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceDynamics.Infrastructure.Data;

public partial class FinanceDbContext : DbContext
{
    public FinanceDbContext()
    {
    }

    public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<ExpenseTransactionReceipt> ExpenseTransactionReceipts { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<IncomeTransactionReceipt> IncomeTransactionReceipts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // -- Expenses
        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasIndex(e => e.GuidId, "IX_Expenses_GuidId").IsUnique();

            // converte DateTime <=> TEXT "yyyy-MM-dd"
            entity.Property(e => e.DateTime)
                .HasConversion(
                    v => v.ToString("yyyy-MM-dd"),
                    v => DateTime.Parse(v)
                )
                .HasColumnType("DATETIME");
        });

        // -- ExpenseTransactionReceipt
        modelBuilder.Entity<ExpenseTransactionReceipt>(entity =>
        {
            entity.HasOne(d => d.Guid)
                  .WithMany(p => p.ExpenseTransactionReceipts)
                  .HasPrincipalKey(p => p.GuidId)
                  .HasForeignKey(d => d.GuidId);
        });

        // -- Incomes
        modelBuilder.Entity<Income>(entity =>
        {
            entity.HasIndex(e => e.GuidId, "IX_Incomes_GuidId").IsUnique();

            entity.Property(e => e.DateTime)
                .HasConversion(
                    v => v.ToString("yyyy-MM-dd"),
                    v => DateTime.Parse(v)
                )
                .HasColumnType("DATETIME");
        });

        // -- IncomeTransactionReceipt
        modelBuilder.Entity<IncomeTransactionReceipt>(entity =>
        {
            entity.HasOne(d => d.Guid)
                  .WithMany(p => p.IncomeTransactionReceipts)
                  .HasPrincipalKey(p => p.GuidId)
                  .HasForeignKey(d => d.GuidId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}