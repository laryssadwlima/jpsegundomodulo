﻿using jpsegundomodulo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace jpsegundomodulo.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Matricula).HasColumnType("varchar(30)");
            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");
            builder.Property(t => t.Curso).HasColumnType("varchar(50)");
            builder.Property(t => t.Periodo).HasColumnType("varchar(14)");
            builder.Property(t => t.Email).HasColumnType("varchar(60)");
            builder.Property(t => t.StatusAluno).HasColumnType("varchar(10)");
            builder.Property(t => t.DataNascimento).HasColumnType("date");
            builder.Property(t => t.Telefone).HasColumnType("varchar(15)");
            builder.Property(t => t.Cep).HasColumnType("varchar(50)");
        }
    }
}

