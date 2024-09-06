using jpsegundomodulo.Models;

namespace jpsegundomodulo.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        void EditarAluno(Aluno aluno);
        void DeletarAluno(Aluno aluno);
    }
}
