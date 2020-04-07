using System;

namespace E2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom = "Francisco";
            String cognom = "Rivas Martín";
            String nomComplet = nom + " " + cognom;
            int dia = 14;
            int mes = 08;
            int any = 1978;
            String dataNaixement = dia + "/" + mes + "/" + any;
            int nAnyTraspas = 4;

            if((any % nAnyTraspas) == 0)
            {
                Console.WriteLine("El meu nom és " + nomComplet);
                Console.WriteLine("Vaig néixer el " + dataNaixement);
                Console.WriteLine("El meu any de naixement és de traspàs.");
            } else
            {
                Console.WriteLine("El meu nom és " + nomComplet);
                Console.WriteLine("Vaig néixer el " + dataNaixement);
                Console.WriteLine("El meu any de naixement no és de traspàs.");
            }

               
        }
    }
}
