using iBiblioteca.DATA.Models;

namespace iBiblioteca.WEB.Models
{
    // Modelo de visualização que combina várias entidades de dados relacionadas.
    public class VwModel
    {
        // Propriedades para representar entidades individuais.
        public Tbautor oAutor { get; set; }                // Representa um autor.
        public Tbeditora oEditora { get; set; }            // Representa uma editora.
        public Tbcolecao oColecao { get; set; }            // Representa uma coleção.
        public TbcapaLivro oCapaLivro { get; set; }        // Representa uma capa de livro.
        public Tblivro oLivro { get; set; }                // Representa um livro.

        // Listas de entidades para representar coleções de dados relacionados.
        public List<Tbautor> oListAutor { get; set; }      // Lista de autores.
        public List<Tbeditora> oListEditora { get; set; }  // Lista de editoras.
        public List<Tbcolecao> oListColecao { get; set; }  // Lista de coleções.
        public List<TbcapaLivro> oListCapaLivro { get; set; } // Lista de capas de livros.
        public List<Tblivro> oListLivro { get; set; }      // Lista de livros.
    }
}
