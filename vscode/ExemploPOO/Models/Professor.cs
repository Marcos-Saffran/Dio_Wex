using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa // sealed -> não pode ser herdada
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. Sou um professor com salário de {Salario.ToString("C2")}");
        }
    }
}