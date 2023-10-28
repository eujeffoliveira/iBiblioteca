using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Repositories
{
    // Classe RepositoryAutor para operações relacionadas a autores
    public class RepositoryAutor : RepositoryBase<Tbautor>, IRepositoryAutor
    {
        // Construtor da classe, com um parâmetro opcional SaveChanges
        // SaveChanges determina se as alterações no repositório são salvas automaticamente
        public RepositoryAutor(bool SaveChanges = true) : base(SaveChanges)
        {
            // O construtor da classe base RepositoryBase<Tbautor> é chamado,
            // passando o valor SaveChanges como argumento.
        }
    }
}