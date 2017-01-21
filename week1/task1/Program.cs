using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
       bool IsPrime(int x)
        {
            int count = 0;
            for (int i=1; i<=x; i++)
            {
                if (x % i == 0)
                    count = count + 1;
            }
            if (count > 2)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            int a;
            for (int i = 0; i < args.Length; i++)
            {
                 a = int.Parse(args[i]);
                if (IsPrime(a) == true)
                    Console.WriteLine(args[i]);
            }
            Console.ReadKey();
           
        }
    }
}
