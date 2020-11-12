using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Trim().Split()
                .Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == sum)
                    {
                        Console.WriteLine($"{numbers[i]}, {numbers[j]}");
                    }
                }
            }
        }
    }
}
