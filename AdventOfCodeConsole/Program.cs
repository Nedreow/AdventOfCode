using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCodeConsole.Utilities;

namespace AdventOfCodeConsole // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? input = null;
            while (string.IsNullOrEmpty(input))
            {
                Console.Write("Please paste input: ");
                input = Console.ReadLine();
            }
            Console.WriteLine(input);
        }
    }
}