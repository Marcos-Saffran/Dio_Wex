using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor); // Método abstrato, deve ser implementado nas classes filhas

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo.ToString("C2")}");
        }
        
    }
}