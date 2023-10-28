using iBiblioteca.DATA.Repositories;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados a capas de livros.
    public class CapaLivroService
    {
        // Repositório utilizado para acessar e manipular dados de capas de livros.
        public RepositoryCapa oRepositoryCapa { get; set; }

        // Construtor da classe.
        public CapaLivroService()
        {
            // Inicializa o repositório de capas de livros no construtor.
            oRepositoryCapa = new RepositoryCapa();
        }
    }
}