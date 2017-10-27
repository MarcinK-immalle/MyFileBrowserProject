using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBrowserProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if( args.Length == 0 )
            {
                Console.WriteLine("Geef een argument");
            }
            else
            {
                switch (args[0])
                {
                    case "-f":
                        Console.WriteLine("Alle files in de huidige directory");
                        break;
                    case "-c":
                        Console.WriteLine("Huidige directory");
                        break;
                    case "-d":
                        Console.WriteLine("Alle subdirectories in de huidige directory");
                        break;
                    case "-h":
                        Console.WriteLine("Toont help");
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }
        }
    }
}
