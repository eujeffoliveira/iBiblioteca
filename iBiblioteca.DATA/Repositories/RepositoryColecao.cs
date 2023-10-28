using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Repositories
{
    // Classe RepositoryColecao para operações relacionadas a coleções de livros
    public class RepositoryColecao : RepositoryBase<Tbcolecao>, IRepositoryColecao
    {
        // Construtor da classe, com um parâmetro opcional SaveChanges
        // SaveChanges determina se as alterações no repositório são salvas automaticamente
        public RepositoryColecao(bool SaveChanges = true) : base(SaveChanges)
        {
            // O construtor da classe base RepositoryBase<Tbcolecao> é chamado,
            // passando o valor SaveChanges como argumento.
        }
    }
}
