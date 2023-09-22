﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Models
{
    // Define a classe Tbcolecao que representa uma coleção de livros
    [Table("TBCOLECAO")] // Define o nome da tabela no banco de dados
    public partial class Tbcolecao
    {
        [Key] // Indica que a propriedade Id é a chave primária da tabela
        [Column("ID")] // Define o nome da coluna no banco de dados
        public int Id { get; set; } // Propriedade que representa o ID da coleção

        [Required] // Indica que o campo Nome é obrigatório
        [Column("NOME")] // Define o nome da coluna no banco de dados
        [StringLength(50)] // Define o comprimento máximo da string
        [Unicode(false)] // Indica que o campo não aceita caracteres Unicode
        [Display(Name = "Nome da Coleção")] // Define o rótulo a ser exibido em interfaces de usuário
        public string Nome { get; set; } // Propriedade que representa o nome da coleção

        [InverseProperty("IdColecaoNavigation")] // Indica a propriedade de navegação inversa
        public virtual ICollection<Tblivro> Tblivro { get; set; } = new List<Tblivro>();
        // Propriedade de navegação que representa a coleção de livros relacionados a esta coleção
        // É inicializada como uma nova lista vazia por padrão
    }
}