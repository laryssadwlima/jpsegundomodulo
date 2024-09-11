using jpsegundomodulo.Models;
namespace jpsegundomodulo.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();
        void InserirProfessor(Professor professor);
        Professor BuscarId(int id);
        void EditarProfessor(Professor professor);
        void DeletarProfessor(Professor professor);
    }
}
