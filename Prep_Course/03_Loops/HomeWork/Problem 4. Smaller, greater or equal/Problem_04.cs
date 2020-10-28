/*
Write a program that reads from the console a sequence of n integer numbers 
and returns these numbers on a single line with the correct sign (<, > or =) 
between the numbers.
*/

using System;

namespace Problem_4._Smaller__greater_or_equal
{
    class Problem_04
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Problem 4. Smaller, greater or equal?");

            Console.Write("input: ");
            int n = int.Parse(Console.ReadLine());

            string result = "";

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // calculation
            result += $"{numbers[0]}";

            for (int i = 0; i < (n - 1); i++)
            {
                if (numbers[i+1] > numbers[i])
                {
                    result += $"<{numbers[i + 1]}";
                }
                else if (numbers[i + 1] < numbers[i])
                {
                    result += $">{numbers[i + 1]}";
                }
                else
                {
                    result += $"={numbers[i + 1]}";
                }
            }

            // output
            Console.WriteLine($"result: {result}");

        }
    }
}
