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
    }
}
