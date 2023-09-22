using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador responsável por ações relacionadas aos autores.
    public class AutorController : Controller
    {
        // Serviços relacionados aos autores.
        private AutorServices oAutorServices = new AutorServices();

        // Ação que exibe a lista de autores.
        public IActionResult Index()
        {
            // Obtém a lista de autores do repositório.
            List<Tbautor> oListAutor = oAutorServices.oRepositoryAutor.SelecionarTodos();
            // Exibe a lista de autores na view.
            return View(oListAutor);
        }

        #region Incluir
        // Ação que exibe o formulário para criar um novo autor.
        public IActionResult Create()
        {
            return View();
        }

        // Ação que processa o formulário de criação de um novo autor.
        [HttpPost]
        public IActionResult Create(Tbautor model)
        {
            // Verifica se o modelo é válido.
            if (!ModelState.IsValid)
            {
                return View();
            }
            // Inclui o novo autor no repositório.
            oAutorServices.oRepositoryAutor.Incluir(model);

            return View();
        }
        #endregion

        #region Detalhes
        // Ação que exibe os detalhes de um autor específico.
        public IActionResult Details(int? id)
        {
            // Obtém o autor com base no ID fornecido.
            Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);
            return View(oAutor);
        }
        #endregion

        #region Editar
        // Ação que exibe o formulário para editar um autor.
        public IActionResult Edit(int? id)
        {
            // Obtém o autor com base no ID fornecido.
            Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);
            return View(oAutor);
        }

        // Ação que processa o formulário de edição de um autor.
        [HttpPost]
        public IActionResult Edit(Tbautor model)
        {
            // Obtém o autor com base no modelo e realiza a alteração.
            Tbautor oAutor = oAutorServices.oRepositoryAutor.Alterar(model);
            int id = oAutor.Id;
            // Redireciona para a página de detalhes do autor após a edição.
            return RedirectToAction("Details", new { id });
        }
        #endregion

        #region Excluir
        // Ação que exclui um autor com base no ID fornecido.
        public IActionResult Delete(int? id)
        {
            // Exclui o autor com base no ID fornecido.
            oAutorServices.oRepositoryAutor.Excluir(id);
            // Redireciona para a lista de autores após a exclusão.
            return RedirectToAction("Index");
        }
        #endregion
    }
}
