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

            static void Err(string msg)
            { 
                                                                
            }
                                                    
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
             }
        }
}
