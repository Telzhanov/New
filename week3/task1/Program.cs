using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void ShowDirectoryContent(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] x = di.GetDirectories();
            for (int i = 0; i < x.Length; ++i)
            {


                if (index == i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Write(list[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

            }
        }
            static void Main(string[] args)
        {
            int index = 0;
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        break;
                }
            }

        }
    }
}
