using System;
using System.Linq;

namespace Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Input
                3 4
                8 3 3
                6 2 4 2
                Output
                4 6 7 2
             */

            /*
             * tens: n / 10
             * ones: n % 10
             */

            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int[] inputOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();


            BigNumberSum(lengths, inputOne, inputTwo);
        }



        static void BigNumberSum(int[] lengths, int[] inputOne, int[] inputTwo)
        {
            // part 1 - input -  build 2 working arrays and 1 result array
            int n = Math.Max(lengths[0], lengths[1]);

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];
            int[] result = new int[n + 1];

            if (lengths[0] < lengths[1])
            {
                for (int i = 0; i < lengths[0]; i++)
                {
                    arrayOne[i] = inputOne[i];
                }

                arrayTwo = (int[])inputTwo.Clone();
            }
            else if (lengths[0] > lengths[1])
            {
                arrayOne = (int[])inputOne.Clone();

                for (int i = 0; i < lengths[1]; i++)
                {
                    arrayTwo[i] = inputTwo[i];
                }
            }
            else
            {
                arrayOne = (int[])inputOne.Clone();
                arrayTwo = (int[])inputTwo.Clone();
            }

            // part 2 - calculation - filling the result array
            int carryon = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = (arrayOne[i] + arrayTwo[i]) % 10;
                }
                else if (i == result.Length - 1)
                {
                    result[i] = (arrayOne[i - 1] + arrayTwo[i - 1]) / 10;
                }
                else
                {
                    result[i] = (arrayOne[i] + arrayTwo[i]) % 10 + (arrayOne[i - 1] + arrayTwo[i - 1]) / 10 + carryon;

                    carryon = 0;

                    if (result[i] > 9)
                    {
                        carryon = result[i] / 10;
                        result[i] = result[i] % 10;
                    }
                }
            }

            // part 3 - returning the result
            if (result[n] == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{result[i]} ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));

            }


        }
    }
}
