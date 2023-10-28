using iBiblioteca.DATA.Repositories;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados à visualização de livros.
    public class VwLivroService
    {
        // Repositório utilizado para acessar e manipular dados da visualização de livros.
        public RepositoryVwLivro oRepositoryVwLivro { get; set; }

        // Construtor da classe.
        public VwLivroService()
        {
            // Inicializa o repositório da visualização de livros no construtor.
            oRepositoryVwLivro = new RepositoryVwLivro();
        }
    }
}