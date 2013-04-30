using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace Grep
{
    class Program
    {
        static void Err(string msg)
        { 
        
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(args.Length);
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter an argument");
            }
        }
    }
}
