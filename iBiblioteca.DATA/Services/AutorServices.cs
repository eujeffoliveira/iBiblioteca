using iBiblioteca.DATA.Repositories;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados a autores.
    public class AutorServices
    {
        // Repositório utilizado para acessar e manipular dados de autores.
        public RepositoryAutor oRepositoryAutor { get; set; }

        // Construtor da classe.
        public AutorServices()
        {
            // Inicializa o repositório de autores no construtor.
            oRepositoryAutor = new RepositoryAutor();
        }
    }
}