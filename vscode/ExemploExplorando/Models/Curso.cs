using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public required string Nome { get; set; }
        public required List<Pessoa> Alunos { get; set; } // propriedade Alunos

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
            // foreach (var aluno in Alunos)
            // {
            //     Console.WriteLine($" - {aluno.NomeCompleto}");
            // }

            for (int count = 0; count < Alunos.Count; count++)
            {
                // concatenação de strings
                string textoConcatenado = "N° -> " + (count + 1) + " - Nome -> " + Alunos[count].NomeCompleto;
                // interpolação de strings
                string textoInterpolado = $"N° -> {{{count + 1}}} - Nome -> {Alunos[count].NomeCompleto}";
                Console.WriteLine("Concatenado = " + textoConcatenado);
                Console.WriteLine("Interpolado = " + textoInterpolado);
            }
        }

        public int ObterAlunosMatriculados()
        {
            return Alunos.Count;
        }
    }
}