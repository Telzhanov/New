using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDirectoryContest(@"c:\Windows");
            
        }
        
        static void ShowDirectoryContest(string path)
        {
            int i = 0;
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                i++;
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(d.Name);
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(d.Name);
            }
        }
    }
 }
