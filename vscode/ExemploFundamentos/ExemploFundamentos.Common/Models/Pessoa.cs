using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Classe que representa uma pessoa
    /// </summary>
    public class Pessoa
    {
        // atributos
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; } = string.Empty;

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos.");
        }
    }
}