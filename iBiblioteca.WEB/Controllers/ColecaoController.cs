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
    }
}
