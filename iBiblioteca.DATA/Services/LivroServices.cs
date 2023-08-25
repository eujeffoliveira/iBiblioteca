using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    public class LivroServices
    {
        public RepositoryLivro oRepositoryLivro { get; set; }
        public LivroServices()
        {
            oRepositoryLivro = new RepositoryLivro();
        }
    }
}
