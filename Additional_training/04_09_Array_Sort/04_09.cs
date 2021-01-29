using System;
using System.Linq;
using System.Collections.Generic;

namespace _04_09_Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            List<int> sorted = new List<int>();
            List<int> zroes = new List<int>();

            // calculation
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != 0)
                {
                    sorted.Add(input[i]);
                }
                else
                {
                    zroes.Add(input[i]);
                }
            }

            sorted.AddRange(zroes);

            Console.WriteLine(string.Join(",", sorted));
        }
    }
}
