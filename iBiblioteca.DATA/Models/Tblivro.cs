﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Models
{
// A classe Tblivro representa a entidade Livro no banco de dados.
[Table("TBLIVRO")] // Atributo que mapeia a classe para a tabela "TBLIVRO" no banco de dados.
[Index("IdAutor", Name = "IX_TBLIVRO_ID_AUTOR")] // Índice para a chave estrangeira IdAutor.
[Index("Isbn", Name = "IX_TBLIVRO_ISBN")] // Índice para o campo Isbn.
[Index("Titulo", Name = "IX_TBLIVRO_TITULO")] // Índice para o campo Titulo.
public partial class Tblivro
{
    [Key] // Atributo que indica que a propriedade "Id" é a chave primária da tabela.
    [Column("ID")] // Atributo que mapeia a propriedade para a coluna "ID" no banco de dados.
    public int Id { get; set; } // Propriedade que representa o ID do livro.

    [Required] // Atributo que indica que a propriedade "Titulo" é obrigatória.
    [Column("TITULO")] // Atributo que mapeia a propriedade para a coluna "TITULO" no banco de dados.
    [StringLength(100)] // Define o tamanho máximo da string.
    [Unicode(false)] // Indica que a string não é unicode.
    [Display(Name = "Título")] // Atributo que especifica o nome de exibição da propriedade.
    public string Titulo { get; set; } // Propriedade que representa o título do livro.

    [Column("ID_AUTOR")] // Atributo que mapeia a propriedade "IdAutor" para a coluna "ID_AUTOR" no banco de dados.
    [Display(Name = "Autor")] // Atributo que especifica o nome de exibição da propriedade.
    public int IdAutor { get; set; } // Propriedade que representa o ID do autor do livro.

    [Column("DATA_PUBLICACAO", TypeName = "date")] // Atributo que mapeia a propriedade "DataPublicacao" para a coluna "DATA_PUBLICACAO" no banco de dados.
    [Display(Name = "Data da Publicação")] // Atributo que especifica o nome de exibição da propriedade.
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] // Formato de exibição da data.
    public DateTime DataPublicacao { get; set; } // Propriedade que representa a data de publicação do livro.

    [Required] // Atributo que indica que a propriedade "Isbn" é obrigatória.
    [Column("ISBN")] // Atributo que mapeia a propriedade para a coluna "ISBN" no banco de dados.
    [StringLength(20)] // Define o tamanho máximo da string.
    [Unicode(false)] // Indica que a string não é unicode.
    [Display(Name = "ISBN")] // Atributo que especifica o nome de exibição da propriedade.
    public string Isbn { get; set; } // Propriedade que representa o ISBN do livro.

    [Column("ID_EDITORA")] // Atributo que mapeia a propriedade "IdEditora" para a coluna "ID_EDITORA" no banco de dados.
    [Display(Name = "Editora")] // Atributo que especifica o nome de exibição da propriedade.
    public int IdEditora { get; set; } // Propriedade que representa o ID da editora do livro.

    [Column("PAGINAS")] // Atributo que mapeia a propriedade "Paginas" para a coluna "PAGINAS" no banco de dados.
    [Display(Name = "Páginas")] // Atributo que especifica o nome de exibição da propriedade.
    public int Paginas { get; set; } // Propriedade que representa o número de páginas do livro.

    [Column("PRECO", TypeName = "decimal(10, 2)")] // Atributo que mapeia a propriedade "Preco" para a coluna "PRECO" no banco de dados.
    [Display(Name = "Preço")] // Atributo que especifica o nome de exibição da propriedade.
    public decimal Preco { get; set; } // Propriedade que representa o preço do livro.

    [Column("ID_CAPA")] // Atributo que mapeia a propriedade "IdCapa" para a coluna "ID_CAPA" no banco de dados.
    [Display(Name = "Imagem Capa")] // Atributo que especifica o nome de exibição da propriedade.
    public int? IdCapa { get; set; } // Propriedade que representa o ID da imagem da capa do livro.

    [Column("ID_COLECAO")] // Atributo que mapeia a propriedade "IdColecao" para a coluna "ID_COLECAO" no banco de dados.
    [Display(Name = "Coleção")] // Atributo que especifica o nome de exibição da propriedade.
    public int? IdColecao { get; set; } // Propriedade que representa o ID da coleção do livro.

    [ForeignKey("IdAutor")] // Atributo que indica a chave estrangeira para a propriedade "IdAutor".
    [InverseProperty("Tblivro")] // Atributo que especifica a propriedade de navegação reversa na classe Tbautor.
    [Display(Name = "Autor")] // Atributo que especifica o nome de exibição da propriedade.
    public virtual Tbautor IdAutor1 { get; set; } // Propriedade de navegação para o autor do livro.

    [ForeignKey("IdCapa")] // Atributo que indica a chave estrangeira para a propriedade "IdCapa".
    [InverseProperty("Tblivro")] // Atributo que especifica a propriedade de navegação reversa na classe TbcapaLivro.
    [Display(Name = "Imagem Capa")] // Atributo que especifica o nome de exibição da propriedade.
    public virtual TbcapaLivro IdCapaNavigation { get; set; } // Propriedade de navegação para a imagem da capa do livro.

    [ForeignKey("IdColecao")] // Atributo que indica a chave estrangeira para a propriedade "IdColecao".
    [InverseProperty("Tblivro")] // Atributo que especifica a propriedade de navegação reversa na classe Tbcolecao.
    [Display(Name = "Coleção")] // Atributo que especifica o nome de exibição da propriedade.
    public virtual Tbcolecao IdColecaoNavigation { get; set; } // Propriedade de navegação para a coleção do livro.

    [ForeignKey("IdEditora")] // Atributo que indica a chave estrangeira para a propriedade "IdEditora".
    [InverseProperty("Tblivro")] // Atributo que especifica a propriedade de navegação reversa na classe Tbeditora.
    [Display(Name = "Editora")] // Atributo que especifica o nome de exibição da propriedade.
    public virtual Tbeditora IdEditoraNavigation { get; set; } // Propriedade de navegação para a editora do livro.

    [ForeignKey("IdLivro")] // Atributo que indica a chave estrangeira para a propriedade "IdLivro".
    [InverseProperty("IdLivro")] // Atributo que especifica a propriedade de navegação reversa na classe Tbautor.
    public virtual ICollection<Tbautor> IdAutorNavigation { get; set; } = new List<Tbautor>(); // Coleção de autores relacionados ao livro.
    }
}