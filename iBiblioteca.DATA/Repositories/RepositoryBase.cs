using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace iBiblioteca.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected DBIBIBLIOTECAContext _Contexto;
        public bool _SaveChanges = true;
        public RepositoryBase(bool SaveChanges = true)
        {
            _Contexto = new DBIBIBLIOTECAContext();
            _SaveChanges = SaveChanges;
        }        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return objeto;
        }
        public void Dispose()
        {
           _Contexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
        }
        public void Excluir(params object[] variavel)
        {
            var objeto = SelecionarPK(variavel);
            Excluir(objeto);
        }

        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return objeto;
        }
        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }
        public T SelecionarPK(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }
        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }
    }
}
