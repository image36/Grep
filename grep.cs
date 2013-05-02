using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace Grep
{
    class Program{
        private static bool recursive = false;
        private static string pattern = string.Empty;
        private static string path = string.Empty;
        static void Main(string[] args)
        {
            System.Console.WriteLine(args.Length);
            if (args.Length == 0 || args[0] == "-?")
            { 
                //help message
                Console.WriteLine(@"Grep lists files based on matching Regular Expression.
                Arguments:
                -?                  Show help message.
                -r                  Recursively search files and subdirectories.
                -v                  Invert match.
                -l                  Suppress normal output and just show file names
                -i                  Ignore case.
                ");
            }
           private static void readArgs(string[] args)
           {
                foreach (var arg in args)
                {
                    if(arg == "-r")
                    {
                        recursiveMode = true;
                    }
                    else if(arg == "-i")
                    {
                        ignoreCase = true;
                    }
                    else if(arg == "-v")
                    {
                        invertMatch = true;
                    }
                    else if(arg == "-l")
                    {
                        fileNameOnly = true;
                    }
                    else if (arg.Length > 2)
    
                    { 
                    
                    }
                }
           }
           private static void readFiles()
           {
               var dirs = Directory.GetDirectories();
               var files = Directory.GetFiles();
               foreach (var fi in files)
               {
                   string text = File.ReadAllText(f);
               }
           }
        }
}