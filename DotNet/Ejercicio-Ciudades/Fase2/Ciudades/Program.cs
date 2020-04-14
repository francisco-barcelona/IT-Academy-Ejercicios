using System;

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

            Array.Sort(arrayCiutats);

            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                Console.WriteLine(arrayCiutats[i]);
            }
        }
    }
}
