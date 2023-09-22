using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador responsável por ações relacionadas às editoras de livros.
    public class EditoraController : Controller
    {
        // Serviços relacionados às editoras de livros.
        public EditoraService oEditoraService = new EditoraService();

        // Ação que exibe a lista de editoras de livros.
        public IActionResult Index()
        {
            // Obtém a lista de editoras de livros do repositório.
            List<Tbeditora> oListEditora = oEditoraService.oRepositoryEditora.SelecionarTodos();
            // Exibe a lista de editoras de livros na view.
            return View(oListEditora);
        }

        #region Incluir
        // Ação que exibe o formulário para criar uma nova editora de livros.
        public IActionResult Create()
        {
            return View();
        }

        // Ação que processa o formulário de criação de uma nova editora de livros.
        [HttpPost]
        public IActionResult Create(Tbeditora model)
        {
            // Verifica se o modelo é válido.
            if (!ModelState.IsValid)
            {
                return View();
            }
            // Inclui a nova editora de livros no repositório.
            oEditoraService.oRepositoryEditora.Incluir(model);
            return View();
        }
        #endregion

        #region Detalhes
        // Ação que exibe os detalhes de uma editora de livros específica.
        public IActionResult Details(int id)
        {
            // Obtém a editora de livros com base no ID fornecido.
            Tbeditora oEditora = oEditoraService.oRepositoryEditora.SelecionarPK(id);
            return View(oEditora);
        }
        #endregion

        #region Alterar
        // Ação que exibe o formulário para editar uma editora de livros.
        public IActionResult Edit(int id)
        {
            // Obtém a editora de livros com base no ID fornecido.
            Tbeditora oEditora = oEditoraService.oRepositoryEditora.SelecionarPK(id);
            return View(oEditora);
        }

        // Ação que processa o formulário de edição de uma editora de livros.
        [HttpPost]
        public IActionResult Edit(Tbeditora model)
        {
            // Obtém a editora de livros com base no modelo e realiza a alteração.
            Tbeditora oEditora = oEditoraService.oRepositoryEditora.Alterar(model);
            // Redireciona para a lista de editoras de livros após a edição.
            return RedirectToAction("Index");
        }
        #endregion

        #region Excluir
        // Ação que exclui uma editora de livros com base no ID fornecido.
        public IActionResult Delete(int id)
        {
            // Exclui a editora de livros com base no ID fornecido.
            oEditoraService.oRepositoryEditora.Excluir(id);
            // Redireciona para a lista de editoras de livros após a exclusão.
            return RedirectToAction("Index");
        }
        #endregion
    }
}