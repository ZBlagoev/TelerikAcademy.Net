using System;
using System.Linq;

namespace Ordering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(SortPots(input));
        }

        static string SortPots(int[] input)
        {
            int[] ascending = new int[input.Length];
            Array.Copy(input, ascending, input.Length);

            int[] descending = new int[input.Length];
            Array.Copy(input, descending, input.Length);

            Array.Sort(ascending);
            Array.Sort(descending);

            Array.Reverse(descending);

            string result = "";

            if (ascending.SequenceEqual(input))
            {
                result = "Ascending";
            }
            else if (descending.SequenceEqual(input))
            {
                result = "Descending";
            }
            else
            {
                result = "Mixed";
            }

            return result;
        }
    }
}
