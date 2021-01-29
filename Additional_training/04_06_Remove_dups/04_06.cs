using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_06_Remove_dups
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> input = Console.ReadLine().Split(',').ToList();

            List<string> uniques = input.Distinct().ToList();

            // output
            Console.WriteLine(string.Join(",", uniques));

        }
    }
}
