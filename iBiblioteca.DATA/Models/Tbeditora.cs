﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Models;

[Table("TBEDITORA")]
public partial class Tbeditora
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("NOME")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nome { get; set; }

    [InverseProperty("IdEditoraNavigation")]
    public virtual ICollection<Tblivro> Tblivro { get; set; } = new List<Tblivro>();
}