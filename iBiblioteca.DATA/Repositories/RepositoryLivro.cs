using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Repositories
{
    // Classe RepositoryLivro para operações relacionadas a livros
    public class RepositoryLivro : RepositoryBase<Tblivro>, IRepositoryLivro
    {
        // Construtor da classe, com um parâmetro opcional SaveChanges
        // SaveChanges determina se as alterações no repositório são salvas automaticamente
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {
            // O construtor da classe base RepositoryBase<Tblivro> é chamado,
            // passando o valor SaveChanges como argumento.
        }
    }
}