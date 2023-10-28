using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        // Contexto do banco de dados
        protected DBIBIBLIOTECAContext _Contexto;

        // Indica se as alterações devem ser automaticamente salvas no banco de dados
        public bool _SaveChanges = true;

        // Construtor da classe
        public RepositoryBase(bool SaveChanges = true)
        {
            // Inicializa o contexto do banco de dados
            _Contexto = new DBIBIBLIOTECAContext();

            // Define se as alterações devem ser automaticamente salvas ou não
            _SaveChanges = SaveChanges;
        }

        // Método para alterar um objeto
        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return objeto;
        }

        // Método para liberar os recursos do contexto do banco de dados
        public void Dispose()
        {
            _Contexto.Dispose();
        }

        // Método para excluir um objeto
        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
        }

        // Sobrecarga do método para excluir um objeto com base em sua chave primária
        public void Excluir(params object[] variavel)
        {
            var objeto = SelecionarPK(variavel);
            Excluir(objeto);
        }

        // Método para incluir um objeto
        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return objeto;
        }

        // Método para salvar as alterações no banco de dados
        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        // Método para selecionar um objeto com base em sua chave primária
        public T SelecionarPK(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        // Método para selecionar todos os objetos do tipo T
        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }
    }
}
