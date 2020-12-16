/*
Least Majority Multiple
Given five positive integers, their least majority multiple is the smallest positive integer that is 
divisible by at least three of them.

Your task is to write a program that for given distinct integers a, b, c, d and e, returns their least 
majority multiple.

For example if we have 1, 2, 3, 4 and 5 the majority multiple of the given five numbers is 4 because it 
is divisible by 1, 2, and 4.

Another example: if we have 30, 42, 70, 35 and 90 the answer will be 210, because it is divisible by 
30, 42, 70, and 35 - four out of five numbers, which is a majority.

Input
Read from the standard input

The input data will consist of 5 lines.

The numbers a, b, c, d and e will each be on a single line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
Print on the standard output

On the only output line you must print the least majority multiple of the given numbers.

Constraints
a, b, c, d and e will each be integer numbers between 1 and 100, inclusive.
a, b, c, d and e will be distinct.
*/

using System;

namespace Least_majority_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine(LMM(numbers));
        }

        // method for getting 3 non repeating elements from the array and getting their Least Majority Multiplier
        static int LMM(int[] numbers)
        {
            Array.Sort(numbers);

            int result = int.MaxValue;

            for (int i = 2; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (k == j)
                        {
                            continue;
                        }
                        else if (k == i)
                        {
                            continue;
                        }

                        int lmmBuffer = LCM(numbers[i], LCM(numbers[j], numbers[k]));

                        if (lmmBuffer < result)
                        {
                            result = lmmBuffer;
                        }
                    }
                }
            }

            return result;
        }

        // method for Least Common Multiplier
        static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        // method for Greatest Common Divisor
        static int GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;

            /*
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }               
            }

            return a | b;
            */
        }


    }
}
