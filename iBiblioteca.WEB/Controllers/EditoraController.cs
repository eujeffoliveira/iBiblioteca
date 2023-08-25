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
    }
}
