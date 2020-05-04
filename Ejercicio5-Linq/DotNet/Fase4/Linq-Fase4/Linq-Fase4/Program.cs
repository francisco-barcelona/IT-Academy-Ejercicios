using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> listaNombres = new List<string>() { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
            var nombresEmpiezanO = listaNombres.Where(s => s.Contains("O")).ToList<string>();
            var nombresLargos6 = listaNombres.Where(s => s.Length > 6).ToList<string>();
            var nombresOrdenados = listaNombres.OrderByDescending(s=>s.Substring(0));

            Console.WriteLine("Noms que comencen amb O: ");
            foreach (String nombre in nombresEmpiezanO){
                Console.WriteLine(nombre);
            }
            Console.WriteLine("Noms amb més de 6 caràcters: ");
            foreach (String nombre in nombresLargos6)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine("Noms ordenats: ");
            foreach(String nombre in nombresOrdenados)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
