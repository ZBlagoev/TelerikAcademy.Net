using System;
using System.Linq;

namespace Appearance_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCounter(numbers, target));
        }

        static int AppearanceCounter(int[] numbers, int target)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == target)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
