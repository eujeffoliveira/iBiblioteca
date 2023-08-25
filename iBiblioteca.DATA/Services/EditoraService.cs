using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    public class EditoraService
    {
        public RepositoryEditora oRepositoryEditora { get; set; }
        public EditoraService()
        {
            oRepositoryEditora = new RepositoryEditora();
        }
    }
}
