using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador responsável por ações relacionadas aos livros.
    public class LivroController : Controller
    {
        private LivroServices oLivroService = new LivroServices();

        // Ação que exibe a lista de livros.
        public IActionResult Index()
        {
            // Obtém a lista de livros do repositório.
            List<Tblivro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }

        #region Incluir
        // Ação que exibe o formulário de inclusão de livro.
        public IActionResult Create()
        {
            return View();
        }

        // Ação que trata o formulário de inclusão de livro (POST).
        [HttpPost]
        public IActionResult Create(Tblivro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Inclui o livro no repositório.
            oLivroService.oRepositoryLivro.Incluir(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region Detalhes
        // Ação que exibe os detalhes de um livro.
        public IActionResult Details(int id)
        {
            // Obtém o livro do repositório com base no ID.
            Tblivro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            return View(oLivro);
        }
        #endregion

        #region Alterar
        // Ação que exibe o formulário de edição de livro.
        public IActionResult Edit(int id)
        {
            // Obtém o livro do repositório com base no ID.
            Tblivro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            return View(oLivro);
        }

        // Ação que trata o formulário de edição de livro (POST).
        [HttpPost]
        public IActionResult Edit(Tblivro model)
        {
            // Altera o livro no repositório.
            Tblivro oLivro = oLivroService.oRepositoryLivro.Alterar(model);
            int id = oLivro.Id;
            return RedirectToAction("Details", new { id });
        }
        #endregion

        #region Excluir
        // Ação que exclui um livro.
        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}