using System;
using System.Linq;

namespace Largest_than_Neigh
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(LargestThanNeigh(numbers, length));
        }

        static int LargestThanNeigh(int[] numbers, int length)
        {
            int counter = 0;

            for (int i = 1; i < length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
