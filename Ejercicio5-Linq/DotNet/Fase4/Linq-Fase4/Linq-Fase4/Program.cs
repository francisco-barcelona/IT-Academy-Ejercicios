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
            String[] listaNombres = {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol"};
            IEnumerable<String> nombresEmpiezanO = from n in listaNombres
                                                   where n.Contains("O")
                                                   select n;
            IEnumerable<String> nombresLargos6 = from n in listaNombres
                                                 where n.Length > 6
                                                 select n;
            IEnumerable<String> nombresOrdenados = from n in listaNombres
                                                   orderby n descending
                                                   select n;

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
