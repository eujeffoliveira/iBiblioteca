using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    public class CapaLivroController : Controller
    {
        private CapaLivroService oCapaLivroService = new CapaLivroService();     

        public IActionResult Index()
        {
            List<TbcapaLivro> oListCapaLivro = oCapaLivroService.oRepositoryCapa.SelecionarTodos();
            return View(oListCapaLivro);
        }
        #region Incluir
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TbcapaLivro model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            oCapaLivroService.oRepositoryCapa.Incluir(model);
            return View();
        }
        #endregion

        #region Detalhes
        public IActionResult Details(int id)
        {
            TbcapaLivro oCapaLivro = oCapaLivroService.oRepositoryCapa.SelecionarPK(id);
            return View(oCapaLivro);
        }
        #endregion

        #region Alterar
        public IActionResult Edit(int id)
        {
            TbcapaLivro oCapaLivro = oCapaLivroService.oRepositoryCapa.SelecionarPK(id);
            return View(oCapaLivro);
        }
        [HttpPost]
        public IActionResult Edit(TbcapaLivro model)
        {
            TbcapaLivro oCapaLivro = oCapaLivroService.oRepositoryCapa.Alterar(model);
            int id = oCapaLivro.Id;
            return RedirectToAction("Details", new { id });
        }
        #endregion

        #region Excluir
        public IActionResult Delete(int id)
        {
            oCapaLivroService.oRepositoryCapa.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
