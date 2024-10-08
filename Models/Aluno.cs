﻿namespace jpsegundomodulo.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string Curso { get; set; }
        public int Periodo { get; set; }
        public string Email { get; set; }
        public string StatusAluno { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
    }

}
