using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;
        public string surname;
        public string gpa;
        public override string ToString()
        {
            return name + " "  + surname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            first.name = "Askhat";
            first.surname = "Telhznaov";
            first.gpa = "3.2";
            Console.WriteLine(first.ToString());
            Console.ReadKey();
        }
    }
}
