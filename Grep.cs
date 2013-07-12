using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Command_line_practice
{
    class Program
    {
        private static string pattern = string.Empty;
        private static String path = string.Empty;
        private static bool recursive = false;
        private static bool supress = false;
        private static string Help = @"This application lists files based on matching Regular Expression.
                Arguments:
                -?                  Show help message.
                -pattern            What to search for.
                -path               Where to search.
                -r or -R            Recursive search
                -i                  Supress results to show only file names.
                ";
        static void Main(string[] args)
        {
            readArgs(args);
            DisplayArgs(args);
            if (pattern == "")
            {
                string msg = string.Format("Pattern can not be empty ");
                Console.Write(msg);
            }
            if (pattern != "")
            {
                System.Console.WriteLine(@"Your search in {0} for {1} returned the following:       
Start:**********************************************************************
****************************************************************************
            ", path, pattern);
                SearchDirectory(path, pattern, recursive, supress);
            }
            System.Console.WriteLine(
@"End:************************************************************************
****************************************************************************");

            System.Console.ReadKey();
        }
        private static void readArgs(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.ToLower().StartsWith("-pattern"))
                {
                    var x = arg.Substring(9);
                    pattern = x;
                }
                else if (arg.ToLower().StartsWith("-path"))
                {
                    var x = arg.Substring(6);
                    path = x;
                }
                else if (arg.StartsWith("-?"))
                {
                    System.Console.WriteLine(Help);
                }
                else if (arg.ToLower().StartsWith("-r"))
                {
                    recursive = true;
                }
                else if (arg.ToLower().StartsWith("-l"))
                {
                    supress = true;
                }
                else
                {
                    System.Console.WriteLine("{0} is not a valid argument", arg);
                    System.Console.WriteLine(Help);
                }
            }
        }
        private static void DisplayArgs(string []args)
        {
            string msg = string.Format("There were {0} args passed", args.Length);
            System.Console.WriteLine(msg);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        public static void SearchDirectory(string path, string pattern, bool recursive, bool supress)
        {
            string[] RecursiveFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            string[] NotRecursiveFiles = Directory.GetFiles(path);
            string[] files;
            try
            {
                if (recursive == true)
                {
                    files = RecursiveFiles;
                }
                else 
                {
                    files = NotRecursiveFiles;
                }
                foreach (var f in files)
                {
                    var file = new FileInfo(f);
                    {
                        if (Regex.IsMatch(file.Name, pattern, RegexOptions.IgnoreCase) && supress == true)
                        {
                            Console.WriteLine(file.Name);
                        }
                        else if (Regex.IsMatch(file.Name, pattern, RegexOptions.IgnoreCase) && supress == false)
                        {
                            Console.WriteLine(file.DirectoryName + "\\" + file.Name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
