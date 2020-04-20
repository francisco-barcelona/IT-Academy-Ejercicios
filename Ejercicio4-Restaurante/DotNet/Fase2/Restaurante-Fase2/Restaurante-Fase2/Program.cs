using System;
using System.Collections.Generic;

namespace Restaurante_Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitllet5 = 5;
            int bitllet10 = 10;
            int bitllet20 = 20;
            int bitllet50 = 50;
            int bitllet100 = 100;
            int bitllet200 = 200;
            int bitllet500 = 500;
            int preuTotal;
            var menu = new String[5];
            var preuPlat = new int[5];
            List<String> comanda = new List<String>();
            int mesMenjar = 1;

            for(int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"Añadir el nombre del plato {i}");
                menu[i] = Console.ReadLine();
                Console.WriteLine($"Añadir el precio del plato {i}");
                preuPlat[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i] + " " + preuPlat[i]);
            }

            Console.WriteLine("Què volen per menjar?");
            comanda.Add(Console.ReadLine());

            while (mesMenjar == 1)
            {
                Console.WriteLine("Volen menjar alguna cosa més (1:Si / 0:No)?");
                mesMenjar = int.Parse(Console.ReadLine());
                if (mesMenjar == 1)
                {
                    comanda.Add(Console.ReadLine());
                } else {
                    Console.WriteLine("Ara els hi porto el dinar");
                }
            }
        }
    }
}
