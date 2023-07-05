using Microsoft.AspNetCore.Mvc;

namespace ControleContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult adicionarContato()
        {
            return View();
        }
        public IActionResult editarContato()
        {
            return View();
        }
        public IActionResult apagarContatoConfirmacao()
        {
            return View();
        }
    }
}
