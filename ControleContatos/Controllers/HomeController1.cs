using Microsoft.AspNetCore.Mvc;

namespace ControleContatos.Controllers
{
    public class ContatoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
