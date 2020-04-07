using System;

namespace E2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const int primerTraspas = 1948;
            String nom = "Paco";
            String cognom1 = "Rivas";
            String cognom2 = "Martín";
            int dia = 14;
            int mes = 08;
            int any = 1978;
            int nAnyTraspas = 4;
            int totalAnys = 0;

            totalAnys = (any - primerTraspas) / 4;
            Console.WriteLine(totalAnys);

            
        }
    }
}
