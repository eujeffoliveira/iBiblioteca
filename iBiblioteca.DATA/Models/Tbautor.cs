﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Models;

[Table("TBAUTOR")]
public partial class Tbautor
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("NOME")]
    [StringLength(50)]
    [Unicode(false)]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    [Required]
    [Column("SOBRENOME")]
    [StringLength(50)]
    [Unicode(false)]
    [Display(Name = "Sobrenome")]
    public string Sobrenome { get; set; }

    [Required]
    [Column("NOME_CONHECIDO")]
    [StringLength(50)]
    [Unicode(false)]
    [Display(Name = "Nome Conhecido")]
    public string NomeConhecido { get; set; }

    [Required]
    [Column("NACIONALIDADE")]
    [StringLength(50)]
    [Unicode(false)]
    [Display(Name = "Nacionalidade")]
    public string Nacionalidade { get; set; }

    // Coleção de Tblivro associada a este autor (relação um-para-muitos)
    [InverseProperty("IdAutor1")]
    public virtual ICollection<Tblivro> Tblivro { get; set; } = new List<Tblivro>();

    // Coleção de Tblivro associada a este autor (relação muitos-para-um)
    [ForeignKey("IdAutor")]
    [InverseProperty("IdAutorNavigation")]
    public virtual ICollection<Tblivro> IdLivro { get; set; } = new List<Tblivro>();
}