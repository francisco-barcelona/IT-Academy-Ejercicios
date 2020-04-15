using System;

namespace E2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int any = 1978;
            int nAnyTraspas = 4;
            //bool isTraspas = false;
            String vAnyTraspas = "És un any de traspàs";
            String fAnyTraspas = "No és un any de traspàs";

            for(int primerTraspas = 1948; primerTraspas <= any; primerTraspas++)
            {
                if (primerTraspas % nAnyTraspas == 0)
                {
                    Console.WriteLine(primerTraspas + " " + vAnyTraspas);
                } else
                {
                    Console.WriteLine(primerTraspas + " " + fAnyTraspas);
                }
            }            
        }
    }
}
