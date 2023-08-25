using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    public class ColecaoService
    {
        public RepositoryColecao oRepositoryColecao = new RepositoryColecao();
        public ColecaoService()
        {
            oRepositoryColecao = new RepositoryColecao();
        }
    }
}
