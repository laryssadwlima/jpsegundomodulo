using jpsegundomodulo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace jpsegundomodulo.Data.Mapeamento
{
    public class ProfMapeamento : IEntityTypeConfiguration<Prof>
    {
        public void Configure(EntityTypeBuilder<Prof> builder)
        {
            builder.ToTable("Prof");

            builder.HasKey(t => t.Id);

          
            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");
            builder.Property(t => t.Atuacao).HasColumnType("varchar(100)");
            builder.Property(t => t.Disciplina).HasColumnType("varchar(255)");
            builder.Property(t => t.Email).HasColumnType("varchar(60)");
            builder.Property(t => t.StatusProfessor).HasColumnType("varchar(20)");
            builder.Property(t => t.Formacao).HasColumnType("varchar(100)");
            builder.Property(t => t.Telefone).HasColumnType("varchar(15)");
            builder.Property(t => t.CEP).HasColumnType("varchar(50)");
        }
    }
}

