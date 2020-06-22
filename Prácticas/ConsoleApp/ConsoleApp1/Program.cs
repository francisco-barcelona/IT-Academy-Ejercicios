﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static string EscapeWord = "exit";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");

            var notasDeAlumnos = new List<double>();
            var nombresDeAlumnos = new List<string>();
            var keepDoing = true;

            while (keepDoing)
            {
                Console.WriteLine($"Nombre del alumno {nombresDeAlumnos.Count + 1}:");
                var nombreText = Console.ReadLine();
                if (nombreText == EscapeWord)
                {
                    keepDoing = false;
                } else
                {
                    Console.WriteLine($"Nota del alumno {notasDeAlumnos.Count + 1}:");
                    var notaText = Console.ReadLine();

                    if (notaText == EscapeWord)
                    {
                        keepDoing = false;
                    }
                    else
                    {
                        nombresDeAlumnos.Add(nombreText);

                        var nota = 0.0;

                        if (double.TryParse(notaText.Replace(".", ","), out nota))
                        {
                            notasDeAlumnos.Add(nota);
                        }
                        else
                        {
                            Console.WriteLine("La nota introducida es incorrecta melón!");
                        }
                    }
                }                
            }

            Console.WriteLine("Nombres de los alumnos: ");

            for(var i = 0; i < nombresDeAlumnos.Count; i++)
            {
                Console.WriteLine(nombresDeAlumnos[i]);
            }

            var suma = 0.0;

            for (var i = 0; i < notasDeAlumnos.Count; i++)
            {
                suma += notasDeAlumnos[i];
            }

            var average = suma / notasDeAlumnos.Count;
            Console.WriteLine("la media los exámenes es: {0}", average);
        }
    }
}
