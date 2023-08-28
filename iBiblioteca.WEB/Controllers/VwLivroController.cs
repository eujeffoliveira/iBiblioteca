using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    public class VwLivroController : Controller
    {
        private VwLivroService oVwLivroService = new VwLivroService();
        public IActionResult Index()
        {
            List<Vwlivro> oListVwLivro = oVwLivroService.oRepositoryVwLivro.SelecionarTodos();
            return View(oListVwLivro);
        }

        #region Incluir

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Vwlivro model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            oVwLivroService.oRepositoryVwLivro.Incluir(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region Detalhes

        public IActionResult Details (int? id)
        {
           Vwlivro oVwLivro = oVwLivroService.oRepositoryVwLivro.SelecionarPK(id);
            return View(oVwLivro);
        }
        #endregion

        #region Alterar

        public IActionResult Edit(int id)
        {
            Vwlivro oVwLivro = oVwLivroService.oRepositoryVwLivro.SelecionarPK(id);
            return View(oVwLivro);
        }
        [HttpPost]
        public IActionResult Edit(Vwlivro model)
        {
            Vwlivro oVwLivro = oVwLivroService.oRepositoryVwLivro.Alterar(model);
            int id = oVwLivro.Id;
            return RedirectToAction("Details", new { id });
        }
        #endregion

        #region Excluir

        public IActionResult Delete(int id)
        {
            oVwLivroService.oRepositoryVwLivro.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion

        #region ObterImagem

        public IActionResult GetImagem(int id)
        {
            var capaLivro = oVwLivroService.oRepositoryVwLivro.SelecionarPK(id);
           
            if (capaLivro != null && capaLivro.Capa != null)
            {
                return File(capaLivro.Capa, "image/jpg");
            }

            var placeholderImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "placeholder.jpg");
            var placeholderBytes = System.IO.File.ReadAllBytes(placeholderImagePath);
            return File(placeholderBytes, "image/jpg");
        }
        #endregion
    }
}
