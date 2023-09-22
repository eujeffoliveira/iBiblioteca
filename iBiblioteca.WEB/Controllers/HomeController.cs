using iBiblioteca.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace iBiblioteca.WEB.Controllers
{
    // Controlador principal responsável por ações relacionadas à página inicial e tratamento de erros.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Construtor que injeta o serviço de registro de log (ILogger) no controlador.
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Ação que exibe a página inicial.
        public IActionResult Index()
        {
            return View();
        }

        // Ação que exibe a página de privacidade.
        public IActionResult Privacy()
        {
            return View();
        }

        // Ação que trata e exibe erros na aplicação.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Obtém o ID da requisição ou um identificador de rastreamento de atividade.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}