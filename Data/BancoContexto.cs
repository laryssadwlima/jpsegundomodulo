using jpsegundomodulo.Data.Mapeamento;
using jpsegundomodulo.Models;
using Microsoft.EntityFrameworkCore;

namespace jpsegundomodulo.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
            modelBuilder.ApplyConfiguration(new ProfMapeamento());

        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Prof> Prof { get; set; }

    }
}
