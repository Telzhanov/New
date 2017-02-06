using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\сулпак\Desktop\PT_G1\week2\task1\task1.txt");
            int max = -2147483648;
            int min = 2147483647;
            for (int i=0; i<lines.Length; i++)
            {
                int a = int.Parse(lines[i]);
                if(max<a)
                {
                    max = a;
                }
               if (min>a)
                {
                    min = a;
                }     
            }
            Console.WriteLine(max + " " + min);
        }
    }
}
