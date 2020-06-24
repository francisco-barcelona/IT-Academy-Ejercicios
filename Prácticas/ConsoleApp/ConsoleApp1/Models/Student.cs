using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        public Student()
        {
        }
        public string Name { get; set; }
        public string Dni { get; set; }
        public List<double> Marks { get; set; }
    }
}
