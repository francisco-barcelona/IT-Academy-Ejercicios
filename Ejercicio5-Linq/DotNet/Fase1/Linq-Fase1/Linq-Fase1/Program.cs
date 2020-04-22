using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = {2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4};
            IEnumerable<int> numeros = from n in listaNumeros
                                       where n % 2 == 0
                                       select n;
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
