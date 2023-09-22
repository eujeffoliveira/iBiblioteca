using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador responsável por ações relacionadas às capas de livros.
    public class CapaLivroController : Controller
    {
        // Serviços relacionados às capas de livros.
        private CapaLivroService oCapaLivroService = new CapaLivroService();

        // Ação que exibe a lista de capas de livros.
        public IActionResult Index()
        {
            // Obtém a lista de capas de livros do repositório.
            List<TbcapaLivro> oListCapaLivro = oCapaLivroService.oRepositoryCapa.SelecionarTodos();
            // Exibe a lista de capas de livros na view.
            return View(oListCapaLivro);
        }

        #region Incluir
        // Ação que exibe o formulário para criar uma nova capa de livro.
        public IActionResult Create()
        {
            return View();
        }

        // Ação que processa o formulário de criação de uma nova capa de livro.
        [HttpPost]
        public IActionResult Create(TbcapaLivro model)
        {
            // Verifica se o modelo é válido.
            if (ModelState.IsValid)
            {
                return View();
            }
            // Inclui a nova capa de livro no repositório.
            oCapaLivroService.oRepositoryCapa.Incluir(model);
            return View();
        }
        #endregion

        #region Detalhes
        // Ação que exibe os detalhes de uma capa de livro específica.
        public IActionResult Details(int id)
        {
            // Obtém a capa de livro com base no ID fornecido.
            TbcapaLivro oCapaLivro = oCapaLivroService.oRepositoryCapa.SelecionarPK(id);
            return View(oCapaLivro);
        }
        #endregion

        #region Alterar
        // Ação que exibe o formulário para editar uma capa de livro.
        public IActionResult Edit(int id)
        {
            // Obtém a capa de livro com base no ID fornecido.
            TbcapaLivro oCapaLivro = oCapaLivroService.oRepositoryCapa.SelecionarPK(id);
            return View(oCapaLivro);
        }

        // Ação que processa o formulário de edição de uma capa de livro.
        [HttpPost]
        public IActionResult Edit(TbcapaLivro model)
        {
            // Obtém a capa de livro com base no modelo e realiza a alteração.
            TbcapaLivro oCapaLivro = oCapaLivroService.oRepositoryCapa.Alterar(model);
            int id = oCapaLivro.Id;
            // Redireciona para a página de detalhes da capa de livro após a edição.
            return RedirectToAction("Details", new { id });
        }
        #endregion

        #region Excluir
        // Ação que exclui uma capa de livro com base no ID fornecido.
        public IActionResult Delete(int id)
        {
            // Exclui a capa de livro com base no ID fornecido.
            oCapaLivroService.oRepositoryCapa.Excluir(id);
            // Redireciona para a lista de capas de livros após a exclusão.
            return RedirectToAction("Index");
        }
        #endregion
    }
}