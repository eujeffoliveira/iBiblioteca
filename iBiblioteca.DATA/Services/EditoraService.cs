using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados a editoras.
    public class EditoraService
    {
        // Repositório utilizado para acessar e manipular dados de editoras.
        public RepositoryEditora oRepositoryEditora { get; set; }

        // Construtor da classe.
        public EditoraService()
        {
            // Inicializa o repositório de editoras no construtor.
            oRepositoryEditora = new RepositoryEditora();
        }
    }
}