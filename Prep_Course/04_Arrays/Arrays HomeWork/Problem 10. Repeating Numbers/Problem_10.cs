/*
Write a program that finds the repeating number. All other numbers occur only once.
*/

using System;
using System.Linq;

namespace Problem_10._Repeating_Numbers
{
    class Problem_10
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 10. Repeating Numbers");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int check;
            int repNr = int.MinValue;

            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                check = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] != check)
                    {
                        continue;
                    }
                    else
                    {
                        repNr = check;
                        break;
                    }
                }
            }

            // output
            Console.WriteLine($"output: {repNr}");
        }
    }
}
