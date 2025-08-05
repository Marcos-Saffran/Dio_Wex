using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private T[] array = new T[capacidade];
        private int contador = 0;

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
                contador++;
            }
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        // public void AdicionarElementoArray(T elemento)
        // {
        //     if (array.Length >= capacidade)
        //     {
        //         Array.Resize(ref array, capacidade * 2);
        //         capacidade *= 2;
        //     }
        //     array[array.Length - 1] = elemento;
        // }

        // public T this[int index]
        // {
        //     get
        //     {
        //         if (index < 0 || index >= contador)
        //         {
        //             throw new IndexOutOfRangeException("Índice fora dos limites do array.");
        //         }
        //         return array[index];
        //     }
        //     set
        //     {
        //         if (index < 0 || index >= contador)
        //         {
        //             throw new IndexOutOfRangeException("Índice fora dos limites do array.");
        //         }
        //         array[index] = value;
        //     }
        // }
    }
}