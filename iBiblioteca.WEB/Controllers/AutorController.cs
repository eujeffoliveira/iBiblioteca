using iBiblioteca.DATA.Models;
using iBiblioteca.DATA.Services;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Create()
        {
            return View();
        }
        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);
        //    if (oAutor == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(oAutor);
        //}
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);
        //    if (oAutor == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(oAutor);
        //}
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    Tbautor oAutor = oAutorServices.oRepositoryAutor.SelecionarPK(id);
        //    if (oAutor == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(oAutor);
        //}  
               
    }
}
