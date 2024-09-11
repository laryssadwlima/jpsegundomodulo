using jpsegundomodulo.Data.Repositorio.Interfaces;
using jpsegundomodulo.Models;
using Microsoft.AspNetCore.Mvc;

namespace jpsegundomodulo.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;
        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }
        public IActionResult Index()
        {
            var professor = _professorRepositorio.BuscarProfessor();
            return View(professor);
        }

        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("index");

        }

        public IActionResult Editar(int id)
        {
            var professor = _professorRepositorio.BuscarId(id);
            return View(professor);
        }
        public IActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("index");
        }

        public IActionResult DeletarProfessor(Professor professor)
        {
            _professorRepositorio.DeletarProfessor(professor);
            return RedirectToAction("Index");
        }
    }
}
