using Cabelos_do_Taeyong.Models;
using Cabelos_do_Taeyong.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Cabelos_do_Taeyong.Controllers
{
    // [Route("[controller]")]
    public class CabelosController : Controller
    {
        private readonly CabelosRepository _repository;

        public CabelosController(CabelosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            @ViewData["Title"] = "Lista";
            List<Cabelos> Cabelos = _repository.ObterCabelos();
            ViewBag.TotalFilmes = Cabelos.Count;
            return View(Cabelos);
        }

        [HttpGet("Cadastro")]
        public IActionResult Cadastro ()
        {
            ViewData ["Title"] = "Cadastro";
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Cabelos t)
        {
            string notaString = Request.Form["nota"].ToString().Replace(".",",");

            if (decimal.TryParse(notaString, out var notaConvertida))
            {
               t.Nota = notaConvertida; 
            }

            _repository.Adicionar(t);
            return RedirectToAction("Index");
        }
    }
}