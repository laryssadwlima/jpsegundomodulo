using jpsegundomodulo.Data.Repositorio.Interfaces;
using jpsegundomodulo.Models;
using Microsoft.AspNetCore.Mvc;

namespace jpsegundomodulo.Controllers
{
    public class ProfController : Controller
    {
        private readonly IProfRepositorio _profRepositorio;
        public ProfController(IProfRepositorio profRepositorio)
        {
            _profRepositorio = profRepositorio;
        }
        public IActionResult Index()
        {
            var prof = _profRepositorio.BuscarProfessores();
            return View(prof);
        }

        public IActionResult AdicionarProf()
        {
            return View();
        }

        public IActionResult InserirProf(Prof prof)
        {
            try
            {
                _profRepositorio.InserirProf(prof);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("index");

        }

        public IActionResult Editar(int id)
        {
            var prof = _profRepositorio.BuscarId(id);
            return View(prof);
        }
        public IActionResult EditarProf(Prof prof)
        {
            _profRepositorio.EditarProf(prof);
            return RedirectToAction("index");
        }

        public IActionResult DeletarProf(Prof prof) 
        {
            _profRepositorio.DeletarProf(prof);
            return RedirectToAction("Index");
        }
    }
}
