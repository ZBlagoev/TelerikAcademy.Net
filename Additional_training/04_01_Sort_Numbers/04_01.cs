using System;
using System.Linq;

namespace _04_01_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.Write(string.Join(", ", numbers));

        }
    }
}
