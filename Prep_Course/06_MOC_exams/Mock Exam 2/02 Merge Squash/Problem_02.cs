using System;

namespace _02_Merge_Squash
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input 
            int n = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int[] merged = new int[n - 1];
            int[] squashed = new int[n - 1];

            string mergedOutput = "";
            string squashedOutput = "";

            // calculation
            for (int i = 0; i < merged.Length; i++)
            {
                merged[i] = (input[i] % 10 * 10) + (input[i + 1] / 10 % 10);
            }

            for (int i = 0; i < squashed.Length; i++)
            {
                int a = input[i] / 10 % 10;
                int b = (input[i] % 10 + input[i + 1] / 10 % 10) % 10;
                int c = input[i + 1] % 10;

                squashed[i] = a * 100 + b * 10 + c;
            }

            // test
            foreach (var item in merged)
            {
                mergedOutput += $"{item} ";
            }

            Console.WriteLine();

            foreach (var item in squashed)
            {
                squashedOutput += $"{item} ";
            }

            // output
            Console.WriteLine(string.Join(" ", mergedOutput));
            Console.WriteLine(string.Join(" ", squashedOutput));
        }
    }
}
