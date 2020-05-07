using System;
using System.Collections.Generic;

namespace Restaurante_Fase4
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
            int bitllet1 = 0;
            int bitllet5 = 0;
            int bitllet10 = 0;
            int bitllet20 = 0;
            int bitllet50 = 0;
            int bitllet100 = 0;
            int bitllet200 = 0;
            int bitllet500 = 0;
            int dineroCliente;
            int cambio;

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
                for (int i = 0; i < menu.Length; i++)
                {
                    if (plat == menu[i])
                    {
                        preuTotal = preuTotal + preuPlat[i];
                        trobat = true;
                    }
                }

                if (trobat == false)
                {
                    Console.WriteLine($"El plat {plat} no es troba al menú");
                }
                else
                {
                    trobat = false;
                }
            }

            Console.WriteLine($"El preu total a pagar és de {preuTotal}");

            // Cambio
            Console.WriteLine("Quants diners dóna el client?");
            dineroCliente = int.Parse(Console.ReadLine());
            cambio = dineroCliente - preuTotal;
            Console.WriteLine($"Su cambio {cambio}");

            if((cambio % 500) > 0)
            {
                bitllet500 = cambio / 500;
                cambio = cambio - (bitllet500 * 500);
            }
            if((cambio % 200) > 0)
            {
                bitllet200 = cambio / 200;
                cambio = cambio - (bitllet200 * 200);
            }
            if ((cambio % 100) > 0)
            {
                bitllet100 = cambio / 100;
                cambio = cambio - (bitllet100 * 100);
            }
            if ((cambio % 50) > 0)
            {
                bitllet50 = cambio / 50;
                cambio = cambio - (bitllet50 * 50);
            }
            if ((cambio % 20) > 0)
            {
                bitllet20 = cambio / 20;
                cambio = cambio - (bitllet20 * 20);
            }
            if ((cambio % 10) > 0)
            {
                bitllet10 = cambio / 10;
                cambio = cambio - (bitllet10 * 10);
            }
            if ((cambio % 5) > 0)
            {
                bitllet5 = cambio / 5;
                cambio = cambio - (bitllet5 * 5);
            }
            if (cambio > 0)
            {
                bitllet1 = cambio;
                cambio = cambio - bitllet1;
            }

            if (bitllet500 > 0)
            {
                Console.WriteLine($"{bitllet500} bitllet/s de 500 euros");
            }
            if (bitllet200 > 0)
            {
                Console.WriteLine($"{bitllet200} bitllet/s de 200 euros");
            }
            if (bitllet100 > 0)
            {
                Console.WriteLine($"{bitllet100} bitllet/s de 100 euros");
            }
            if (bitllet50 > 0)
            {
                Console.WriteLine($"{bitllet50} bitllet/s de 50 euros");
            }
            if (bitllet20 > 0)
            {
                Console.WriteLine($"{bitllet20} bitllet/s de 20 euros");
            }
            if (bitllet10 > 0)
            {
                Console.WriteLine($"{bitllet10} bitllet/s de 10 euros");
            }
            if (bitllet5 > 0)
            {
                Console.WriteLine($"{bitllet5} bitllet/s de 5 euros");
            }
            if (bitllet1 > 0)
            {
                Console.WriteLine($"{bitllet1} moneda/s de 1 euros");
            }
        }
    }
}
