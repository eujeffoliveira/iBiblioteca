using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Repositories
{
    // A classe RepositoryVwLivro representa um repositório para a entidade Vwlivro.
    // Ela implementa a interface IRepositoryVwLivro e herda funcionalidades da classe RepositoryBase<T>.
    public class RepositoryVwLivro : RepositoryBase<Vwlivro>, IRepositoryVwLivro
    {
        // Construtor da classe RepositoryVwLivro.
        // Aceita um parâmetro opcional SaveChanges que determina se as alterações no contexto de banco de dados
        // devem ser salvas automaticamente após cada operação (padrão é true).
        public RepositoryVwLivro(bool SaveChanges = true) : base(SaveChanges)
        {
            // O construtor recebe um parâmetro opcional SaveChanges que controla o comportamento de salvar mudanças
            // automaticamente no contexto de banco de dados. Por padrão, ele é true, o que significa que as alterações
            // serão salvas automaticamente após cada operação no repositório, a menos que seja especificado o contrário.

            // A classe RepositoryVwLivro é especializada para lidar com a entidade Vwlivro e utiliza a classe base
            // RepositoryBase<T> para herdar métodos e funcionalidades comuns para operações de banco de dados.

            // Qualquer lógica específica para a manipulação da entidade Vwlivro pode ser adicionada aqui ou em métodos
            // adicionais, conforme necessário.
        }
    }
}

