using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroServices oLivroService = new LivroServices();
        public IActionResult Index()
        {
            List<Tblivro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }
        #region Incluir
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tblivro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
           oLivroService.oRepositoryLivro.Incluir(model);
           return RedirectToAction("Index");
        }
        #endregion

        #region Detalhes
        public IActionResult Details(int id)
        {
            Tblivro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            return View(oLivro);
        }
        #endregion

        #region Alterar
        public IActionResult Edit(int id)
        {
            Tblivro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            return View(oLivro);
        }
        [HttpPost]
        public IActionResult Edit(Tblivro model)
        {
            Tblivro oLivro = oLivroService.oRepositoryLivro.Alterar(model);
            int id = oLivro.Id;
            return RedirectToAction("Details", new {id});
        }
        #endregion

        #region Excluir
        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}