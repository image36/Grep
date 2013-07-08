using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Command_line_practice
{
    class Program
    {
        public static string pattern = string.Empty;
        public static string path = string.Empty;
        public static string Help = @"This application lists files based on matching Regular Expression.
                Arguments:
                -?                  Show help message.
                -pattern            What to search for.
                -path               Where to search.
                ";


        static void Main(string[] args)
        {
            readArgs(args);
            System.Console.WriteLine(args.Length);
            System.Console.WriteLine(@"Your search in {0} for {1} returned the following:       
****************************************************************************
****************************************************************************
            ", path, pattern);
            SearchDirectory(path, pattern);
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
                    //System.Console.WriteLine(pattern);

                }
                else if (arg.ToLower().StartsWith("-path"))
                {
                    var x = arg.Substring(6);
                    path = x;
                    //System.Console.WriteLine(path);
                }
                else if (arg.StartsWith("-?"))
                {
                    
                    System.Console.WriteLine(Help);
                }
                else
                {
                    System.Console.WriteLine( "{0} is not a valid argument", arg);
                    System.Console.WriteLine(Help);
                }
                
            }
        }
        public static void SearchDirectory(string path, string pattern)
        {
            try
            {
                string[] files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
                int results = files.GetLength(0);
                Console.WriteLine("The total number of files returned is {0}", results);
                //DirectoryInfo dir = new DirectoryInfo(path, SearchOption.AllDirectories);
                //int count = dir.GetFiles().Length;
                //Console.WriteLine("The total number of files in this directory is {0}", count);
                foreach (string file in files)
                {
                    if (results > 1)
                    {
                        Console.WriteLine(file);
                    }
                    else if (results < 1)
                    {
                        Console.WriteLine("There are no results");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed {0}", e.ToString());
            }
        }
    }
}
