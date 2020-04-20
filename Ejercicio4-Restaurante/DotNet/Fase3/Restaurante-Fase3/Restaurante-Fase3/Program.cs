using System;
using System.Collections.Generic;

namespace Restaurante_Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int preuTotal = 0;
            var menu = new String[5];
            var preuPlat = new int[5];
            List<String> comanda = new List<String>();
            int mesMenjar = 1;
            bool trobat = false;

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"Añadir el nombre del plato {i}");
                menu[i] = Console.ReadLine();
                Console.WriteLine($"Añadir el precio del plato {i}");
                preuPlat[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < menu.Length; i++)
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
                }
                else
                {
                    Console.WriteLine("Ara li portem el dinar");
                }
            }

            foreach (String plat in comanda)
            {
                for(int i = 0; i < menu.Length; i++)
                {
                    if(plat == menu[i])
                    {
                        preuTotal = preuTotal + preuPlat[i];
                        trobat = true;
                    }
                }

                if(trobat == false)
                {
                    Console.WriteLine($"El plat {plat} no es troba al menú");
                }
                else
                {
                    trobat = false;
                }
            }

            Console.WriteLine($"El preu total a pagar és de {preuTotal}");
        }
    }
}
