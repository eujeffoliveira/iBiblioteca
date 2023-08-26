using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

namespace iBiblioteca.WEB.Controllers
{
    public class AutorController : Controller
    {
        private AutorServices oAutorServices = new AutorServices();
        public IActionResult Index()
        {
            List<Tbautor> oListAutor = oAutorServices.oRepositoryAutor.SelecionarTodos();
            return View(oListAutor);
        }
        #region Incluir
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tbautor model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            oAutorServices.oRepositoryAutor.Incluir(model);

            return View();
        }
        #endregion

        #region Detalhes
        public IActionResult Details(int? id)
        {            
            Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);            
            return View(oAutor);
        }
        #endregion

        #region Editar
        public IActionResult Edit(int? id)
        {
            Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);
            return View(oAutor);
        }
        [HttpPost]
        public IActionResult Edit(Tbautor model)
        {            
            Tbautor oAutor = oAutorServices.oRepositoryAutor.Alterar(model);
            int id = oAutor.Id;
            return RedirectToAction("Details", new { id });           
        }
        #endregion

        #region Excluir
        public IActionResult Delete(int? id)
        {
            oAutorServices.oRepositoryAutor.Excluir(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
