using Agencia46.Data;
using Agencia46.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Agencia46.Controllers
{
    public class GerenciadorUController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["usuarios"] = dbcontext.Usuarios.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuarios usuarios)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(usuarios);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Usuarios usuarios)
        {
            var dbcontext = new Contexto();

            var usuariosDelete = dbcontext.Usuarios.Find(usuarios.Id);
            dbcontext.Remove(usuariosDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Usuarios novosDadosUsuarios)
        {
            var dbcontext = new Contexto();

            var antigosDadosUsuarios = dbcontext.Usuarios.Find(novosDadosUsuarios.Id);

            antigosDadosUsuarios.Nome = novosDadosUsuarios.Nome;
            antigosDadosUsuarios.Email = novosDadosUsuarios.Email;
            antigosDadosUsuarios.CPF = novosDadosUsuarios.CPF;
            antigosDadosUsuarios.Endereco = novosDadosUsuarios.Endereco;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
