using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Valor {valor} creditado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido para crédito.");
            }
        }
    }
}