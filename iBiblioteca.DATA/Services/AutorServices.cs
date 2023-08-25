using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    public class AutorServices
    {
        public RepositoryAutor oRepositoryAutor { get; set; }
        public AutorServices()
        {
            oRepositoryAutor = new RepositoryAutor();
        }
    }
}
