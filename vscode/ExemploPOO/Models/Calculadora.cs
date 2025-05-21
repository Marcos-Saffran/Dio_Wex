using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        // public double Dividir(double a, double b)
        // {
        //     if (b == 0)
        //     {
        //         throw new DivideByZeroException("Divisão por zero não é permitida.");
        //     }
        //     return a / b;
        // }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }
    }   
}