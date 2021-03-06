﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> listaNumeros = new List<int>() { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            var numeros = listaNumeros.Where(s => s > 5).ToList<int>();
            var numeros2 = listaNumeros.Where(s => s < 5).ToList<int>();

            Console.WriteLine("Números més grans que 5");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Números més petits que 5");
            foreach (int numero in numeros2)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
