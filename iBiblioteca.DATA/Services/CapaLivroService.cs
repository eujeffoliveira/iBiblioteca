using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    public class CapaLivroService
    {
        public RepositoryCapa oRepositoryCapa { get; set; }
        public CapaLivroService()
        {
            oRepositoryCapa = new RepositoryCapa();
        }
    }
}
