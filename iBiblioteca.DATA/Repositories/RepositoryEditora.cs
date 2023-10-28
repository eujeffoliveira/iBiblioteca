using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Repositories
{
    // Classe RepositoryEditora para operações relacionadas a editoras de livros
    public class RepositoryEditora : RepositoryBase<Tbeditora>, IRepositoryEditora
    {
        // Construtor da classe, com um parâmetro opcional SaveChanges
        // SaveChanges determina se as alterações no repositório são salvas automaticamente
        public RepositoryEditora(bool SaveChanges = true) : base(SaveChanges)
        {
            // O construtor da classe base RepositoryBase<Tbeditora> é chamado,
            // passando o valor SaveChanges como argumento.
        }
    }
}