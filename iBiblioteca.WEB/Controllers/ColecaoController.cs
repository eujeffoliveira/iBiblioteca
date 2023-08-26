using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    public class ColecaoController : Controller
    {
        private ColecaoService oColecaoService = new ColecaoService();
        public IActionResult Index()
        {
            List<Tbcolecao> oListColecao = oColecaoService.oRepositoryColecao.SelecionarTodos();
            return View(oListColecao);
        }
        #region Incluir
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tbcolecao model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oColecaoService.oRepositoryColecao.Incluir(model);
            return View();                         
        }
        #endregion

        #region Detalhes
        public IActionResult Details(int id)
        {
            Tbcolecao oColecao = oColecaoService.oRepositoryColecao.SelecionarPK(id);
            return View(oColecao);
        }
        #endregion

        #region ALterar
        public IActionResult Edit(int id)
        {
            Tbcolecao oColecao = oColecaoService.oRepositoryColecao.SelecionarPK(id);
            return View(oColecao);
        }
        [HttpPost]
        public IActionResult Edit(Tbcolecao model)
        {
            Tbcolecao oColecao = oColecaoService.oRepositoryColecao.Alterar(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region Excluir
        public IActionResult Delete(int id)
        {
            oColecaoService.oRepositoryColecao.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
