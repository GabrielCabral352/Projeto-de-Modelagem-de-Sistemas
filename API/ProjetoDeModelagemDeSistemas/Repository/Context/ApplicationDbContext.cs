﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Repository.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Pais> Pais { get; set; }
    public DbSet<Atividade> Atividades { get; set; }
    public DbSet<Crianca> Criancas { get; set; }
    public DbSet<CriancaAtividade> CriancaAtividades { get; set; }
    public DbSet<CriancaRecompensa> CriancaRecompensas { get; set; }
    public DbSet<Recompensa> Recompensas { get; set; }

    public ApplicationDbContext([NotNull] DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
