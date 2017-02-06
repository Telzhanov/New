using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace example3
{
    class Program
    {
        static void ShowDirectoryContent(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] x = di.GetDirectories();

            for (int i = 1; i < x.Length; ++i)
            {
                Console.WriteLine(x[i].Name);
            }
            

        }
        private static void F1()
        {
            ShowDirectoryContent(@"C:\");
        }
        static void Main(string[] args)
        {
            F1();  
 
        }
    }
}
