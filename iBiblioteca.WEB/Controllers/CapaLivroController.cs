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
    }
}
