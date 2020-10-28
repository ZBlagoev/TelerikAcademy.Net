using System;

namespace Problem_1._Numbers_from_1_to_N
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 1. Numbers from 1 to N");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            string result = "";

            // calculation
            for (int i = 1; i <= n; i++)
            {
                result += $"{i} ";
            }

            // output
            Console.WriteLine($"result: {result}");

        }
    }
}
