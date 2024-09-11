using jpsegundomodulo.Models;

namespace jpsegundomodulo.Data.Repositorio.Interfaces
{
    public interface IProfRepositorio
    {
        List<Prof> BuscarProfessores();
        void InserirProf(Prof prof);
        Prof BuscarId(int id);
        void EditarProf(Prof prof);
        void DeletarProf(Prof prof);
    }
}
