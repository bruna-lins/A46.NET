using Agencia46.Data;
using Agencia46.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Agencia46.Controllers
{
    public class GerenciadorDController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["destinos"] = dbcontext.Destinos.Where(p => p.Id_Destino > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Destinos destinos)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(destinos);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Destinos destinos)
        {
            var dbcontext = new Contexto();

            var destinosDelete = dbcontext.Destinos.Find(destinos.Id_Destino);
            dbcontext.Remove(destinosDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Destinos novosDadosDestinos)
        {
            var dbcontext = new Contexto();

            var antigosDadosDestinos = dbcontext.Destinos.Find(novosDadosDestinos.Id_Destino);

            antigosDadosDestinos.Nome_Dest = novosDadosDestinos.Nome_Dest;
            antigosDadosDestinos.Pais = novosDadosDestinos.Pais;
            antigosDadosDestinos.Preco = novosDadosDestinos.Preco;
            antigosDadosDestinos.Status = novosDadosDestinos.Status;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
