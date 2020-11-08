/*
You are given n integers (given in a single line, separated by a space).

Write a program that checks whether the product of the odd elements is 
equal to the product of the even elements.

Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;
using System.Collections.Generic;

namespace Problem_99._Odd_and_Even_Product
{
    class Problem_93
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Additional NON-Required Problem: Odd and Even Product");

            Console.Write("input: ");
            string input = Console.ReadLine();

            string[] numStr = input.Split(" ");
            int n = numStr.Length;
            int[] numbers = Array.ConvertAll(numStr, int.Parse);

                // placeholders for the number of odd and even int below 'n' 
            int even = (int)Math.Floor((double)n / 2.00);
            int odd = n - even;          
            
            List<int> evenN = new List<int>();
            List<int> oddN = new List<int>();

            int prodEven = 1;
            int prodOdd = 1;

            // calculation
                // populate even and odd lists
                // note: values of odd and even must be flipped because index starts at 0
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddN.Add(numbers[i]);
                }
                else
                {
                    evenN.Add(numbers[i]);
                }
            }

                // calculate products
            foreach (int number in evenN)
            {
                prodEven *= number;
            }

            foreach (int number in oddN)
            {
                prodOdd *= number;
            }

            // output
            Console.WriteLine("result: ");

            if (prodEven == prodOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine($"product = {prodOdd}");
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine($"odd_product = {prodOdd}");
                Console.WriteLine($"even_product = {prodEven}");
            }



        }
    }
}
