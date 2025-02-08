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

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCadastro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("data_cadastro");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Idade).HasColumnName("idade");
            entity.Property(e => e.Nome).HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
