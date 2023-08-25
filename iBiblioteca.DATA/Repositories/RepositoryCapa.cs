using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Repositories
{
    public class RepositoryCapa : RepositoryBase<TbcapaLivro>, IRepositoryCapa
    {
        public RepositoryCapa(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}
