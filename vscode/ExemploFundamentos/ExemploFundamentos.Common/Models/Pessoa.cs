using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        // atributos
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; } = string.Empty;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos.");
        }
    }
}