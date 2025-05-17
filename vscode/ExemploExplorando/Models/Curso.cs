using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } // propriedade Alunos

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome}:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($" - {aluno.NomeCompleto}");
            }
        }

        public int ObterAlunosMatriculados()
        {
            return Alunos.Count;
        }
    }
}