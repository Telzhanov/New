using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\сулпак\Desktop\PT_G1\week2\task1\task1.txt");
            int min = 2147483647;
            for (int i=0; i<lines.Length; i++)
            {
                int a = int.Parse(lines[i]);
                int count = 0;
                for (int j=1; j<=a; j++)
                {
                    if (a%j==0)
                    {
                        count++;
                    }
                }
                if (count==2)
                {
                    if (min>a)
                    {
                        min = a;
                    }
                }
            }
            using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\сулпак\Desktop\PT_G1\week2\task1\task1.txt", true))
            {
                file.WriteLine("\n" + min);
            }
        }
    }
    }

