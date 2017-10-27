using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFileBrowserProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument");
            }
            else
            {
                switch (args[0])
                {
                    case "-f":
                        ShowAllFilesInCurrentDirectory();
                        break;
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-d":
                        ShowAllSubDirectorys();
                        break;
                    case "-h":
                        ShowHelp();
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }
        }

        static void ShowAllFilesInCurrentDirectory()
        {
            Console.WriteLine("Alle files in de huidige directory");
        }

        static void ShowCurrentDirectory()
        {
            Console.WriteLine("Huidige directory");
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
        }

        static void ShowAllSubDirectorys()
        {
            string path = Directory.GetCurrentDirectory();
            Directory.GetDirectories(path);
            Console.WriteLine();

        }

        static void ShowHelp()
        {
            Console.WriteLine("Toont help");
        }



    }
}
