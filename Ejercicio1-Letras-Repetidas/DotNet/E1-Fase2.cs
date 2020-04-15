using System;
using System.Collections.Generic;

namespace Ejercicio1Net
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> lstNombre = new List<char>()
                {
                    'P',
                    'a',
                    'c',
                    'o'
                };

            List<char> vocals = new List<char>()
                {
                    'A', 'a','e','E','i','I','o','O','u','U'
                };

            List<char> numeros = new List<char>()
            {
                '0','1','2','3','4','5','6','7','8','9'
            };

            foreach (var value in lstNombre)
            {
                // Al comparar con una lista podemos también añadir vocales con tildes, diéresis... Al utilizar IndexOf se busca
                // dentro de la lista de vocales y se compara con cada valor de la lista que contiene el nombre.
                // Si el índice es -1 es que no está dentro de la lista, por eso se compara con >0
                if (numeros.IndexOf(value) > 0)
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
                else
                {
                    if (vocals.IndexOf(value) > 0)
                    {
                        Console.WriteLine("VOCAL");
                    }
                    else
                    {
                        Console.WriteLine("CONSONANT");
                    }

                }


            }
        }
    }
}
