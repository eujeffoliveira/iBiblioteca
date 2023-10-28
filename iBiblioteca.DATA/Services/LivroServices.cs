using iBiblioteca.DATA.Repositories;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados a livros.
    public class LivroServices
    {
        // Repositório utilizado para acessar e manipular dados de livros.
        public RepositoryLivro oRepositoryLivro { get; set; }

        // Construtor da classe.
        public LivroServices()
        {
            // Inicializa o repositório de livros no construtor.
            oRepositoryLivro = new RepositoryLivro();
        }
    }
}