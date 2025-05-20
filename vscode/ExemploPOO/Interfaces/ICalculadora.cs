using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        double Somar(double a, double b);
        double Subtrair(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b)
        {
            const double epsilon = 1e-10;
            if (Math.Abs(b) < epsilon)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return a / b;
        }
        

    }
}