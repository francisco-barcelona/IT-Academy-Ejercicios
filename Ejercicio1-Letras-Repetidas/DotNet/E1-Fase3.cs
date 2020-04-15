using System;
using System.Collections.Generic;

namespace Ejercicio1Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> nombreDic = new Dictionary<char, int>();
            List<char> lstNombre = new List<char>()
                {
                    'P',
                    'a',
                    'c',
                    'o'
                };

            foreach (var val in lstNombre)
            {
                if (nombreDic.ContainsKey(val))
                {
                    nombreDic[val] += 1;

                } else
                {
                    nombreDic.Add(val, 1);
                }
            }
                        
        }
    }
}
