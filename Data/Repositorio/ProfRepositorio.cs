using jpsegundomodulo.Data.Repositorio.Interfaces;
using jpsegundomodulo.Models;
using Microsoft.AspNetCore.Mvc;

namespace jpsegundomodulo.Data.Repositorio
{
    public class ProfRepositorio : IProfRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public ProfRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Prof> BuscarProfessores()
        {
            return _bancoContexto.Prof.ToList();
        }
        public void InserirProf(Prof prof)
        {
            _bancoContexto.Prof.Add(prof);
            _bancoContexto.SaveChanges();
        }

        public Prof BuscarId(int id)
        {
            return _bancoContexto.Prof.FirstOrDefault(x => x.Id == id);
        }

        public void EditarProf(Prof prof)
        {
            _bancoContexto.Prof.Update(prof);
            _bancoContexto.SaveChanges();

        }

        public void DeletarProf(Prof prof)
        {
            _bancoContexto.Prof.Remove(prof);
            _bancoContexto.SaveChanges();
        }


    }
}
