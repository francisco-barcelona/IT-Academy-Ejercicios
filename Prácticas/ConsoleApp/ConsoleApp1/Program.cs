using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static string CurrentOption { get; set; }

        static List<double> Exams { get; set; }
        static List<Student> Students { get; set; }
        static List<string> Subjects { get; set; }
        static List<double> Marks { get; set; }

        static void Main(string[] args)
        {
            Dictionary<string, List<double>> Exams = new Dictionary<string, List<double>>();
            
            Dictionary<string, string> Subjects = new Dictionary<string, string>();

            Dictionary<string, string> Students = new Dictionary<string, string>();

            Console.WriteLine("Bienvenidos al programa de gestión de clase");
            ShowMainMenu();

            while (true)
            {
                var option = Console.ReadKey().KeyChar;

                if (option == 'm')
                {
                    ClearCurrentConsoleLine();
                    if (CurrentOption != "m")
                    {
                        Console.WriteLine();
                        ShowMainMenu();
                    }
                }
                else if (option == 'n')
                {
                    ClearCurrentConsoleLine();
                    if (CurrentOption != "n")
                    {
                        Console.WriteLine();
                        ShowAddNotesMenu(Students,Exams);
                    }
                }
                else if (option == 'c')
                {
                    ClearCurrentConsoleLine();
                    if (CurrentOption != "c")
                    {
                        Console.WriteLine();
                        ShowStatisticsMenu();
                    }
                }
            }
        }

        static void ShowMainMenu()
        {
            CurrentOption = "m";
            Console.WriteLine("Menu de opciones principal");

            Console.WriteLine("Opciones: m - para volver a este menu");
            Console.WriteLine("Opciones: n - añadir notas de alumnos");
            Console.WriteLine("Opciones: c - Estadísticas");
        }        

        static void ShowAddNotesMenu(Dictionary<string, string> Students, Dictionary<string, List<double>> Exams)
        {
            CurrentOption = "n";
            Console.WriteLine("Menu de añadir notas. Añada notas con el formato [dni*nombre*notas] y presione enter");
            Console.WriteLine("Presione m para acabar y volver al menú principal");

            while (true)
            {
                var notaText = Console.ReadLine();

                if (notaText == "m")
                {
                    break;
                }
                else
                {
                    char[] c1 = { '*' };
                    var spaso = notaText.Split(c1);

                    var dni = spaso[0];
                    var name = spaso[1];
                    var markText = spaso[2].Replace(".", ",");

                    #region Nota
                    double nota;
                    if (double.TryParse(markText, out nota))
                    {
                        if (!Students.ContainsKey(dni))
                        {
                            Students.Add(dni, name);
                            Exams.Add(dni, new List<double>());
                            Exams[dni].Add(nota);
                        } else
                        {
                            Exams[dni].Add(nota);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"valor introducido [{notaText}] no válido");
                    }
                    #endregion

                }
            }

            ClearCurrentConsoleLine();
            Console.WriteLine();
            ShowMainMenu();
        }

        static void ShowStatisticsMenu()
        {
            CurrentOption = "c";

            Console.WriteLine("Opción de Estadísticas");
            Console.WriteLine("Presione m para acabar y volver al menú principal");
            Console.WriteLine("Opciones: avg - obtener la media de las notas de los alumnos");
            Console.WriteLine("Opciones: max - obtener la máxima nota de los alumnos");
            Console.WriteLine("Opciones: max - obtener la mínima nota de los alumnos");

            while (true)
            {
                var optionText = Console.ReadLine();

                if (optionText == "m")
                {
                    break;
                }
                else if (optionText == "avg")
                {
                    ShowAverage();
                }
                else if (optionText == "max")
                {
                    ShowMaximum();
                }
                else if (optionText == "min")
                {
                    ShowMinimum();
                }
            }

            ClearCurrentConsoleLine();
            Console.WriteLine();
            ShowMainMenu();
        }

        static void ShowAverage()
        {
            //var avg = GetAverage();
            Console.WriteLine($"La media actual es: {Marks.Average()}");
            Console.WriteLine();
        }

        static void ShowMinimum()
        {
            Console.WriteLine($"La nota más baja es: {Marks.Min()}");
            Console.WriteLine();
        }

        static void ShowMaximum()
        {
            Console.WriteLine($"La nota más alta es: {Marks.Max()}");
            Console.WriteLine();
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        #region Formulas

        public static double GetAverage()
        {
            var sum = 0.0;

            for (var i = 0; i < Marks.Count; i++)
            {
                sum += Marks[i];
            }

            return sum / Marks.Count;
        }


        #endregion
    }
}
