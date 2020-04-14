using System;
using System.Collections.Generic;

namespace Ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            String var1;
            String var2;
            String var3;
            String var4;
            String var5;
            String var6;
            var arrayCiutats = new String[6];

            Console.WriteLine("Escribe el nombre de la ciudad 1");
            var1 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 2");
            var2 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 3");
            var3 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 4");
            var4 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 5");
            var5 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 6");
            var6 = Console.ReadLine();

            arrayCiutats[0] = var1;
            arrayCiutats[1] = var2;
            arrayCiutats[2] = var3;
            arrayCiutats[3] = var4;
            arrayCiutats[4] = var5;
            arrayCiutats[5] = var6;

            char[] arrayCiutatChar0 = arrayCiutats[0].ToCharArray();
            Array.Reverse(arrayCiutatChar0);
            char[] arrayCiutatChar1 = arrayCiutats[1].ToCharArray();
            Array.Reverse(arrayCiutatChar1);
            char[] arrayCiutatChar2 = arrayCiutats[2].ToCharArray();
            Array.Reverse(arrayCiutatChar2);
            char[] arrayCiutatChar3 = arrayCiutats[3].ToCharArray();
            Array.Reverse(arrayCiutatChar3);
            char[] arrayCiutatChar4 = arrayCiutats[4].ToCharArray();
            Array.Reverse(arrayCiutatChar4);
            char[] arrayCiutatChar5 = arrayCiutats[5].ToCharArray();
            Array.Reverse(arrayCiutatChar5);

            for(int i = 0; i < arrayCiutatChar0.Length; i++)
            {
                Console.WriteLine(arrayCiutatChar0[i]);
            }

            for (int i = 0; i < arrayCiutatChar1.Length; i++)
            {
                Console.WriteLine(arrayCiutatChar1[i]);
            }

            for (int i = 0; i < arrayCiutatChar2.Length; i++)
            {
                Console.WriteLine(arrayCiutatChar2[i]);
            }

            for (int i = 0; i < arrayCiutatChar3.Length; i++)
            {
                Console.WriteLine(arrayCiutatChar3[i]);
            }

            for (int i = 0; i < arrayCiutatChar4.Length; i++)
            {
                Console.WriteLine(arrayCiutatChar4[i]);
            }

            for (int i = 0; i < arrayCiutatChar5.Length; i++)
            {
                Console.WriteLine(arrayCiutatChar5[i]);
            }

        }
    }
}
