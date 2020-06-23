using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static string EscapeWord = "exit";
        static string option;
        static string option2;

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");

            var notasDeAlumnos = new List<double>();
            var nombresDeAlumnos = new List<string>();
            var keepDoing = true;

            while (keepDoing)
            {
                menu();
                option = Console.ReadLine();
                if(option == "i")
                {
                    Console.WriteLine($"Nombre del alumno {nombresDeAlumnos.Count + 1}:");
                    var nombreText = Console.ReadLine();
                    if (nombreText == EscapeWord)
                    {
                        keepDoing = false;
                    }
                    else
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
                } else if(option == "s")
                {
                    Console.WriteLine("Nombres de los alumnos: ");

                    for (var i = 0; i < nombresDeAlumnos.Count; i++)
                    {
                        Console.WriteLine(nombresDeAlumnos[i]);
                    }
                } else if(option == "e")
                {
                    estadisticas();
                    option2 = Console.ReadLine();
                    if(option2 == "med")
                    {
                        var suma = 0.0;

                        for (var i = 0; i < notasDeAlumnos.Count; i++)
                        {
                            suma += notasDeAlumnos[i];
                        }

                        var average = suma / notasDeAlumnos.Count;
                        Console.WriteLine("la media los exámenes es: {0}", average);
                    } else if(option2 == "max")
                    {
                        var max = 0.0;
                        max = notasDeAlumnos.Max();
                        Console.WriteLine("la nota máxima de los exámenes es: {0}", max);
                    } else if (option2 == "min")
                    {
                        var min = 0.0;
                        min = notasDeAlumnos.Min();
                        Console.WriteLine("la nota mínima de los exámenes es: {0}", min);
                    } else
                    {
                        Console.WriteLine("La opción escogida no es válida, vuelva a intentarlo.");
                    }
                }
                else
                {
                    
                }                
            } 

            static void menu()
            {
                Console.WriteLine("Menú de opciones de la escuela:");
                Console.WriteLine("Pulsa 'i' para insertar notas de exámenes.");
                Console.WriteLine("Pulsa 's' para ver nombres de alumnos.");
                Console.WriteLine("Pulsa 'e' para ver estadísticas de los alumnos.");
            }  
            
            static void estadisticas()
            {
                Console.WriteLine("Pulsa 'med' para ver la media de las notas de los alumnos");
                Console.WriteLine("Pulsa 'max' para ver la máxima nota de los alumnos");
                Console.WriteLine("Pulsa 'min' para ver la mínima nota de los alumnos");
            }
        }
    }
}
