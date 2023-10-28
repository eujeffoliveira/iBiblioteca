using iBiblioteca.DATA.Repositories;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados a coleções.
    public class ColecaoService
    {
        // Repositório utilizado para acessar e manipular dados de coleções.
        public RepositoryColecao oRepositoryColecao { get; set; }

        // Construtor da classe.
        public ColecaoService()
        {
            // Inicializa o repositório de coleções no construtor.
            oRepositoryColecao = new RepositoryColecao();
        }
    }
}