using iBiblioteca.DATA.Interfaces;
using iBiblioteca.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Repositories
{
    // Classe RepositoryCapa para operações relacionadas a capas de livros
    public class RepositoryCapa : RepositoryBase<TbcapaLivro>, IRepositoryCapa
    {
        // Construtor da classe, com um parâmetro opcional SaveChanges
        // SaveChanges determina se as alterações no repositório são salvas automaticamente
        public RepositoryCapa(bool SaveChanges = true) : base(SaveChanges)
        {
            // O construtor da classe base RepositoryBase<TbcapaLivro> é chamado,
            // passando o valor SaveChanges como argumento.
        }
    }
}