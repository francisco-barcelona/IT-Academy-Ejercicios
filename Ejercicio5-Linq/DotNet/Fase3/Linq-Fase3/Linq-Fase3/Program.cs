using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 }; 
            IEnumerable<int> numerosMesGrans5 = from n in listaNumeros
                                       where n>5
                                       select n;

            IEnumerable<int> numerosMesPetits5 = from n in listaNumeros
                                                where n < 5
                                                select n;

            Console.WriteLine("Números més grans que 5");
            foreach (int numero in numerosMesGrans5)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Números més petits que 5");
            foreach (int numero in numerosMesPetits5)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
