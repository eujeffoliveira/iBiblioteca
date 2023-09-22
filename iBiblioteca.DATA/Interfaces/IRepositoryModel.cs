using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Interfaces
{
    // Interface genérica para repositórios de modelos (classes) onde T é o tipo do modelo.
    public interface IRepositoryModel<T> where T : class
    {
        // Selecionar todos os objetos do tipo T no banco de dados e retorná-los como uma lista.
        List<T> SelecionarTodos();

        // Selecionar um objeto do tipo T com base em sua chave primária.
        T SelecionarPK(params object[] variavel);

        // Incluir um novo objeto do tipo T no banco de dados.
        T Incluir(T objeto);

        // Alterar um objeto do tipo T no banco de dados.
        T Alterar(T objeto);

        // Excluir um objeto do tipo T do banco de dados.
        void Excluir(T objeto);

        // Excluir um objeto com base em sua chave primária.
        void Excluir(params object[] variavel);

        // Salvar todas as alterações pendentes no banco de dados.
        void SaveChanges();
    }
}