using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBiblioteca.WEB.Controllers
{
    public class EditoraController : Controller
    {
        public EditoraService oEditoraService = new EditoraService();
        public IActionResult Index()
        {
            List<Tbeditora> oListEditora = oEditoraService.oRepositoryEditora.SelecionarTodos();
            return View(oListEditora);
        }
        #region Incluir
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tbeditora model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oEditoraService.oRepositoryEditora.Incluir(model);
            return View();
        }
        #endregion

        #region Detalhes
        public IActionResult Details(int id)
        {
            Tbeditora oEditora = oEditoraService.oRepositoryEditora.SelecionarPK(id);
            return View(oEditora);
        }
        #endregion

        #region Alterar
        public IActionResult Edit(int id)
        {
            Tbeditora oEditora = oEditoraService.oRepositoryEditora.SelecionarPK(id);
            return View(oEditora);
        }
        [HttpPost]
        public IActionResult Edit(Tbeditora model)
        {
           Tbeditora oEditora = oEditoraService.oRepositoryEditora.Alterar(model);
           return RedirectToAction("Index");
        }
        #endregion

        #region Excluir
        public IActionResult Delete(int id)
        {
            oEditoraService.oRepositoryEditora.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
