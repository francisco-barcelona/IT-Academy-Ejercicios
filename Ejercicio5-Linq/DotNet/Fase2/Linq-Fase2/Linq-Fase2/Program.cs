using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            double mediaListaNumeros = listaNumeros.Average();
            int maxListaNumeros = listaNumeros.Max();
            int minListaNumeros = listaNumeros.Min();

            Console.WriteLine($"Media de la lista: {mediaListaNumeros}. Máximo de la lista: {maxListaNumeros}. Mínimo de la lista: {minListaNumeros}");
        }
    }
}
