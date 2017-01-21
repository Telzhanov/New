using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
      static bool IsPrime(string a)
        {
            int x = int.Parse(a);
            int count = 0;
            for (int i=1; i<=x; i++)
            {
                if (x % i == 0)
                    count = count + 1;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (IsPrime(args[i]))
                    Console.WriteLine(args[i]);
            }
            Console.ReadKey();
           
        }
    }
}
