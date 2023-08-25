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
    }
}
