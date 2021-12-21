using Microsoft.AspNetCore.Mvc;

namespace Agencia46.Controllers
{
    public class PromosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
