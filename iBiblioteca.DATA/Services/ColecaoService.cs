using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    // Classe que fornece serviços relacionados a coleções.
    public class ColecaoService
    {
        // Repositório utilizado para acessar e manipular dados de coleções.
        public RepositoryColecao oRepositoryColecao { get; set; }

        // Construtor da classe.
        public ColecaoService()
        {
            // Inicializa o repositório de coleções no construtor.
            oRepositoryColecao = new RepositoryColecao();
        }
    }
}