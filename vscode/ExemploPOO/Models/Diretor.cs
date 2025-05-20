using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor //: Pessoa // : Professor (não pode herdar de Professor, pois é sealed)
    {
        public string teste { get; set; }

        // public Diretor()
        // {

        // }
        // public Diretor(string nome) : base(nome)
        // {

        // }
        // public string AreaResponsavel { get; set; }

        // public override void Apresentar()
        // {
        //     Console.WriteLine($"Olá, meu nome é {Nome}. Sou um diretor da área {AreaResponsavel} com salário de {Salario.ToString("C2")}");
        // }
    }

}