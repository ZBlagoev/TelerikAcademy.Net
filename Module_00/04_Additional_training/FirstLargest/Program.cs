using System;
using System.Linq;

namespace FirstLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(FirstLargest(numbers, length));
        }

        static int FirstLargest(int[] numbers, int length)
        {
            int index = 0;

            for (int i = 1; i < length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
