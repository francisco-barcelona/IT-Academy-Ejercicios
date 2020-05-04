using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> listaNumeros = new List<int> () { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            var numeros = listaNumeros.Where(s => s % 2 == 0).ToList<int>();
            
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
