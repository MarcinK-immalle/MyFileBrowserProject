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
            Console.WriteLine("Alle files in de huidige directory: ");
            string[] dirs = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (string dir in dirs)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }
        }

        static void ShowCurrentDirectory()
        {
            Console.WriteLine(Environment.CurrentDirectory);
        }

        static void ShowAllSubDirectorys()
        {
            Console.WriteLine(Directory.GetDirectories(Environment.CurrentDirectory));
        }

        static void ShowHelp()
        {
            Console.WriteLine("-> mfb -c : toont de huidige directory");
            Console.WriteLine("-> mfb - d : toont alle subdirectories in de huidige directory");
            Console.WriteLine("-> mfb - f : toont alle files in de huidige directory");
            Console.WriteLine("-> mfb(zonder argumenten) : toont de huidige directory, alle files en alle directories");
            Console.WriteLine("-> mfb - h : toont help");
        }



    }
}
