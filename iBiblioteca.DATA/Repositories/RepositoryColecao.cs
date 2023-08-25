using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Repositories
{
    public class RepositoryColecao : RepositoryBase<Tbcolecao>, IRepositoryColecao
    {
        public RepositoryColecao(bool SaveChanges = true) : base(SaveChanges)
        {
        }    
    }
}
