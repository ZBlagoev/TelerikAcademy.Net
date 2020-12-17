using System;
using System.Linq;
using System.Collections.Generic;

namespace Array_search
{
    class Program
    {
        static void Main(string[] args)
        {
            MissingElement(Console.ReadLine().Split(',').Select(int.Parse).ToArray());
        }

        static void MissingElement(int[] input)
        {
            List<int> missing = new List<int>();

            for (int i = 1; i <= input.Length; i++)
            {
                if (!input.Contains(i))
                {
                    missing.Add(i);
                }
            }

            Console.WriteLine(String.Join(",",missing));
        }
    }
}
