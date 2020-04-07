using System;
using System.Collections.Generic;

namespace Ejercicio1Net
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> fullName = new List<char>();
            List<char> lstName = new List<char>()
                {
                    'P',
                    'a',
                    'c',
                    'o'
                };

            List<char> lstSurname = new List<char>()
                {
                    'R',
                    'i',
                    'v',
                    'a',
                    's'
                };

            fullName.AddRange(lstName);
            fullName.Add(' ');
            fullName.AddRange(lstSurname);
                        
        }
    }
}
