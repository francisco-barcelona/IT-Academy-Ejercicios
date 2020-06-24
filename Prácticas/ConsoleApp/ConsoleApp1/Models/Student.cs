using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        List<double> Marks;
        public string Name { get; set; }
        public string Dni { get; set; }
        public Student()
        {
        }
        public Student(string _Name,string _Dni, double _nota)
        {
            Name = _Name;
            Dni = _Dni;
            Marks = new List<double>();
            Marks.Add(_nota);
        }

        public void addMarks(double number)
        {
            Marks.Add(number);
        }

        public void printMarks()
        {
            foreach (var x in Marks)
            {
                Console.WriteLine(x);
            }
        }
              
        
    }
}
