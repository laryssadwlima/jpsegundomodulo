using jpsegundomodulo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace jpsegundomodulo.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");
            builder.Property(t => t.Area_atuacao).HasColumnType("varchar(100)");
            builder.Property(t => t.Disciplina).HasColumnType("varchar(14)");
            builder.Property(t => t.Email).HasColumnType("varchar(60)");
            builder.Property(t => t.StatusProfessor).HasColumnType("varchar(10)");
            builder.Property(t => t.Formacao_academica).HasColumnType("date");
            builder.Property(t => t.Telefone).HasColumnType("varchar(15)");
            builder.Property(t => t.Cep).HasColumnType("varchar(50)");
        }
    }
}


