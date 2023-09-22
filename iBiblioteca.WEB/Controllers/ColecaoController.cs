using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador responsável por ações relacionadas às coleções de livros.
    public class ColecaoController : Controller
    {
        // Serviços relacionados às coleções de livros.
        private ColecaoService oColecaoService = new ColecaoService();

        // Ação que exibe a lista de coleções de livros.
        public IActionResult Index()
        {
            // Obtém a lista de coleções de livros do repositório.
            List<Tbcolecao> oListColecao = oColecaoService.oRepositoryColecao.SelecionarTodos();
            // Exibe a lista de coleções de livros na view.
            return View(oListColecao);
        }

        #region Incluir
        // Ação que exibe o formulário para criar uma nova coleção de livros.
        public IActionResult Create()
        {
            return View();
        }

        // Ação que processa o formulário de criação de uma nova coleção de livros.
        [HttpPost]
        public IActionResult Create(Tbcolecao model)
        {
            // Verifica se o modelo é válido.
            if (!ModelState.IsValid)
            {
                return View();
            }
            // Inclui a nova coleção de livros no repositório.
            oColecaoService.oRepositoryColecao.Incluir(model);
            return View();
        }
        #endregion

        #region Detalhes
        // Ação que exibe os detalhes de uma coleção de livros específica.
        public IActionResult Details(int id)
        {
            // Obtém a coleção de livros com base no ID fornecido.
            Tbcolecao oColecao = oColecaoService.oRepositoryColecao.SelecionarPK(id);
            return View(oColecao);
        }
        #endregion

        #region Alterar
        // Ação que exibe o formulário para editar uma coleção de livros.
        public IActionResult Edit(int id)
        {
            // Obtém a coleção de livros com base no ID fornecido.
            Tbcolecao oColecao = oColecaoService.oRepositoryColecao.SelecionarPK(id);
            return View(oColecao);
        }

        // Ação que processa o formulário de edição de uma coleção de livros.
        [HttpPost]
        public IActionResult Edit(Tbcolecao model)
        {
            // Obtém a coleção de livros com base no modelo e realiza a alteração.
            Tbcolecao oColecao = oColecaoService.oRepositoryColecao.Alterar(model);
            // Redireciona para a lista de coleções de livros após a edição.
            return RedirectToAction("Index");
        }
        #endregion

        #region Excluir
        // Ação que exclui uma coleção de livros com base no ID fornecido.
        public IActionResult Delete(int id)
        {
            // Exclui a coleção de livros com base no ID fornecido.
            oColecaoService.oRepositoryColecao.Excluir(id);
            // Redireciona para a lista de coleções de livros após a exclusão.
            return RedirectToAction("Index");
        }
        #endregion
    }
}