using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Repositories
{
    public class RepositoryVwLivro : RepositoryBase<Vwlivro>, IRepositoryVwLivro
    {
        public RepositoryVwLivro(bool SaveChanges = true) : base(SaveChanges)
        {

        }   
    }
}
