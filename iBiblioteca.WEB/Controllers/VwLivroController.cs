using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador responsável por ações relacionadas aos livros de visualização.
    public class VwLivroController : Controller
    {
        private VwLivroService oVwLivroService = new VwLivroService();

        // Ação que exibe a lista de livros de visualização.
        public IActionResult Index()
        {
            // Obtém a lista de livros de visualização do repositório.
            List<Vwlivro> oListVwLivro = oVwLivroService.oRepositoryVwLivro.SelecionarTodos();
            return View(oListVwLivro);
        }

        #region Incluir
        // Ação que exibe o formulário de inclusão de livro de visualização.
        public IActionResult Create()
        {
            return View();
        }

        // Ação que trata o formulário de inclusão de livro de visualização (POST).
        [HttpPost]
        public IActionResult Create(Vwlivro model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Inclui o livro de visualização no repositório.
            oVwLivroService.oRepositoryVwLivro.Incluir(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region Detalhes
        // Ação que exibe os detalhes de um livro de visualização.
        public IActionResult Details(int? id)
        {
            // Obtém o livro de visualização do repositório com base no ID.
            Vwlivro oVwLivro = oVwLivroService.oRepositoryVwLivro.SelecionarPK(id);
            return View(oVwLivro);
        }
        #endregion

        #region Alterar
        // Ação que exibe o formulário de edição de livro de visualização.
        public IActionResult Edit(int id)
        {
            // Obtém o livro de visualização do repositório com base no ID.
            Vwlivro oVwLivro = oVwLivroService.oRepositoryVwLivro.SelecionarPK(id);
            return View(oVwLivro);
        }

        // Ação que trata o formulário de edição de livro de visualização (POST).
        [HttpPost]
        public IActionResult Edit(Vwlivro model)
        {
            // Altera o livro de visualização no repositório.
            Vwlivro oVwLivro = oVwLivroService.oRepositoryVwLivro.Alterar(model);
            int id = oVwLivro.Id;
            return RedirectToAction("Details", new { id });
        }
        #endregion

        #region Excluir
        // Ação que exclui um livro de visualização.
        public IActionResult Delete(int id)
        {
            oVwLivroService.oRepositoryVwLivro.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion

        #region ObterImagem
        // Ação que obtém a imagem de capa de um livro de visualização.
        public IActionResult GetImagem(int id)
        {
            // Obtém o livro de visualização do repositório com base no ID.
            var capaLivro = oVwLivroService.oRepositoryVwLivro.SelecionarPK(id);

            if (capaLivro != null && capaLivro.Capa != null)
            {
                // Retorna a imagem da capa como um arquivo do tipo "image/jpg".
                return File(capaLivro.Capa, "image/jpg");
            }

            // Se não houver capa ou se ocorrer algum erro, retorna uma imagem de espaço reservado.
            var placeholderImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "placeholder.jpg");
            var placeholderBytes = System.IO.File.ReadAllBytes(placeholderImagePath);
            return File(placeholderBytes, "image/jpg");
        }
        #endregion
    }
}