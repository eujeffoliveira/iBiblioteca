using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Repositories
{
    public class RepositoryAutor : RepositoryBase<Tbautor>, IRepositoryAutor
    {
        public RepositoryAutor (bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
