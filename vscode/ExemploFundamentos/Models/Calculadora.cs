using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"A soma de {a} + {b} é: {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"A subtração de {a} - {b} é: {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"A multiplicação de {a} * {b} é: {a * b}");
        }

        public void Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"A divisão de {a} / {b} é: {a / b}");
        }

        public void Potencia(int a, int b)
        {
            Console.WriteLine($"A potência de {a} ^ {b} é: {Math.Pow(a, b)}");
        }

        public void RaizQuadrada(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Raiz quadrada de número negativo não é permitida.");
                return;
            }
            Console.WriteLine($"A raiz quadrada de {a} é: {Math.Sqrt(a)}");
        }

        public void Media(int a, int b)
        {
            Console.WriteLine($"A média de {a} e {b} é: {(a + b) / 2}");
        }

        public void modulo(int a)
        {
            Console.WriteLine($"O módulo de {a} é: {Math.Abs(a)}");
        }

        public void Porcentagem(int a, int b)
        {
            Console.WriteLine($"A porcentagem de {a} em relação a {b} é: {(a * 100) / b}");
        }

        public void Fatorial(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Fatorial de número negativo não é permitido.");
                return;
            }
            int resultado = 1;
            for (int i = 1; i <= a; i++)
            {
                resultado *= i;
            }
            Console.WriteLine($"O fatorial de {a} é: {resultado}");
        }

        public void Resto(int a)
        {
            Console.WriteLine($"O resto da divisão de {a} por 2 é: {a % 2}");
        }

        internal void RestoQue(int v1, int v2)
        {
            Console.WriteLine($"O resto da divisão de {v1} por {v2} é: {v1 % v2}");
        }

        public void Seno(double angulo){
            double radiano = (Math.PI / 180) * angulo;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo} graus é: {Math.Round(seno, 4)}");
            
        }
        public void Coseno(double angulo){
            double radiano = (Math.PI / 180) * angulo;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo} graus é: {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo){
            double radiano = (Math.PI / 180) * angulo;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente de {angulo} graus é: {Math.Round(tangente, 4)}");
        }
    }
}