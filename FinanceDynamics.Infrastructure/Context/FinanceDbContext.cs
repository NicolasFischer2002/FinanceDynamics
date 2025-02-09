using System;
using System.Collections.Generic;
using FinanceDynamics.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceDynamics.Infrastructure.Context;

public partial class FinanceDbContext : DbContext
{
    public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Cdb> Cdbs { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<FinancialInstitution> FinancialInstitutions { get; set; }

    public virtual DbSet<FixedIncome> FixedIncomes { get; set; }

    public virtual DbSet<FixedIncomeFinancialInstitution> FixedIncomeFinancialInstitutions { get; set; }

    public virtual DbSet<Investment> Investments { get; set; }

    public virtual DbSet<InvestmentType> InvestmentTypes { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Revenue> Revenues { get; set; }

    public virtual DbSet<Share> Shares { get; set; }

    public virtual DbSet<SubcategoriesTransaction> SubcategoriesTransactions { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionCategory> TransactionCategories { get; set; }

    public virtual DbSet<TransactionFile> TransactionFiles { get; set; }

    public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<TransactionalMethod> TransactionalMethods { get; set; }

    public virtual DbSet<TypesOfPerson> TypesOfPeople { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VariableIncome> VariableIncomes { get; set; }

    public virtual DbSet<VariableIncomeFinancialInstitution> VariableIncomeFinancialInstitutions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cdb>(entity =>
        {
            entity.ToTable("CDB");

            entity.HasOne(d => d.FixedIncome).WithMany(p => p.Cdbs)
                .HasForeignKey(d => d.FixedIncomeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.ExchangeRateToUsd).HasColumnName("ExchangeRateToUSD");
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.ToTable("Expense");

            entity.Property(e => e.DueDate).HasColumnType("DATETIME");
            entity.Property(e => e.PaymentDate).HasColumnType("DATETIME");

            entity.HasOne(d => d.Transaction).WithMany(p => p.Expenses)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FixedIncome>(entity =>
        {
            entity.ToTable("FixedIncome");

            entity.HasOne(d => d.FixedIncomeFinancialInstitutions).WithMany(p => p.FixedIncomes)
                .HasForeignKey(d => d.FixedIncomeFinancialInstitutionsId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Investment).WithMany(p => p.FixedIncomes)
                .HasForeignKey(d => d.InvestmentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FixedIncomeFinancialInstitution>(entity =>
        {
            entity.HasOne(d => d.FinancialInstitution).WithMany(p => p.FixedIncomeFinancialInstitutions)
                .HasForeignKey(d => d.FinancialInstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Investment>(entity =>
        {
            entity.Property(e => e.Date).HasColumnType("DATETIME");

            entity.HasOne(d => d.InvestmentType).WithMany(p => p.Investments)
                .HasForeignKey(d => d.InvestmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany(p => p.Investments)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");

            entity.HasOne(d => d.TypeOfPerson).WithMany(p => p.People)
                .HasForeignKey(d => d.TypeOfPersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Revenue>(entity =>
        {
            entity.ToTable("Revenue");

            entity.Property(e => e.DateOfReceipt).HasColumnType("DATETIME");

            entity.HasOne(d => d.Transaction).WithMany(p => p.Revenues)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Share>(entity =>
        {
            entity.HasOne(d => d.VariableIncome).WithMany(p => p.Shares)
                .HasForeignKey(d => d.VariableIncomeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SubcategoriesTransaction>(entity =>
        {
            entity.ToTable("SubcategoriesTransaction");

            entity.HasOne(d => d.TransactionCategory).WithMany(p => p.SubcategoriesTransactions)
                .HasForeignKey(d => d.TransactionCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.Property(e => e.Date).HasColumnType("DATETIME");

            entity.HasOne(d => d.Currency).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionCategory).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionalMethod).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionalMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TransactionCategory>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.TransactionCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TransactionFile>(entity =>
        {
            entity.Property(e => e.Date).HasColumnType("DATETIME");

            entity.HasOne(d => d.Transaction).WithMany(p => p.TransactionFiles)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TransactionStatus>(entity =>
        {
            entity.ToTable("TransactionStatus");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.DateCreated).HasColumnType("DATETIME");

            entity.HasOne(d => d.Person).WithMany(p => p.Users)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.StandardCurrency).WithMany(p => p.Users)
                .HasForeignKey(d => d.StandardCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VariableIncome>(entity =>
        {
            entity.ToTable("VariableIncome");

            entity.HasOne(d => d.Investment).WithMany(p => p.VariableIncomes)
                .HasForeignKey(d => d.InvestmentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.VariableIncomeFinancialInstitution).WithMany(p => p.VariableIncomes)
                .HasForeignKey(d => d.VariableIncomeFinancialInstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VariableIncomeFinancialInstitution>(entity =>
        {
            entity.HasOne(d => d.FinancialInstitution).WithMany(p => p.VariableIncomeFinancialInstitutions)
                .HasForeignKey(d => d.FinancialInstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
