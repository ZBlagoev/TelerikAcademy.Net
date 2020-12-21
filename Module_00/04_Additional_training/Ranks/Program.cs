using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranks
{
    class Program
    {
        static void Main(string[] args)
        {
            // input array
            int length = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // ordered array based on input
            int[] ordered = new int[length];

            numbers.CopyTo(ordered, 0);
            Array.Sort(ordered);
            Array.Reverse(ordered);

            // dictionary with ranks of the elements
            var numsRanked = new Dictionary<int, int>();

            for (int i = 0; i < ordered.Length; i++)
            {
                numsRanked.Add(ordered[i], i + 1);
            }

            // print ranks
            foreach (int item in numbers)
            {
                int value = numsRanked[item];
                Console.Write(value + " ");
            }
        }
    }
}
