﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Models;

public partial class DBIBIBLIOTECAContext : DbContext
{
    public DBIBIBLIOTECAContext()
    {
    }

    public DBIBIBLIOTECAContext(DbContextOptions<DBIBIBLIOTECAContext> options)
        : base(options)
    {
    }

    // Define as DbSet para as tabelas do banco de dados
    public virtual DbSet<Tbautor> Tbautor { get; set; }

    public virtual DbSet<TbcapaLivro> TbcapaLivro { get; set; }

    public virtual DbSet<Tbcolecao> Tbcolecao { get; set; }

    public virtual DbSet<Tbeditora> Tbeditora { get; set; }

    public virtual DbSet<Tblivro> Tblivro { get; set; }

    public virtual DbSet<Vwlivro> Vwlivro { get; set; }

    // Configura a conexão com o banco de dados no construtor
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=TARS;Initial Catalog=DBIBIBLIOTECA;Integrated Security=True;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configura a chave primária da entidade Tbautor
        modelBuilder.Entity<Tbautor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TBAUTOR__3214EC2710FBECAC");
        });

        // Configura a chave primária da entidade TbcapaLivro
        modelBuilder.Entity<TbcapaLivro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TBCAPA_L__3214EC2713C2175D");
        });

        // Configura a chave primária da entidade Tbcolecao
        modelBuilder.Entity<Tbcolecao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TBCOLECA__3214EC273695FBD2");
        });

        // Configura a chave primária da entidade Tbeditora
        modelBuilder.Entity<Tbeditora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TBEDITOR__3214EC275E3D9B3F");
        });

        // Configura a chave primária e as relações da entidade Tblivro
        modelBuilder.Entity<Tblivro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TBLIVRO__3214EC27E442566A");

            // Define a relação com a entidade TbcapaLivro
            entity.HasOne(d => d.IdCapaNavigation).WithMany(p => p.Tblivro).HasConstraintName("FK_LIVRO_CAPA");

            // Define a relação com a entidade Tbcolecao
            entity.HasOne(d => d.IdColecaoNavigation).WithMany(p => p.Tblivro).HasConstraintName("FK_LIVRO_COLECAO");

            // Define a relação com a entidade Tbeditora
            entity.HasOne(d => d.IdEditoraNavigation).WithMany(p => p.Tblivro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LIVRO_EDITORA");
        });

        // Define a visualização da entidade Vwlivro
        modelBuilder.Entity<Vwlivro>(entity =>
        {
            entity.ToView("VWLIVRO");
        });

        // Chama o método OnModelCreatingPartial para configurações adicionais
        OnModelCreatingPartial(modelBuilder);
    }

    // Método parcial que pode ser implementado em outra parte do código
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}