/*
Odd and Even Product
Description
You are given N integers, each on a new line

Write a program that checks whether the product of the odd lines is equal to
the product of the even lines.
Lines are counted from 1 to N, so the first line is odd, the second is even, etc.

Input
On the first line you will receive the number N
On each of the next N lines, you will receive a number

Output
If the two products are equal, output a string in the format "yes PRODUCT_VALUE", 
otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

Constraints
N will always be a valid integer number in the range [4, 50]
All input numbers will also be valid integers in range [-1000000, 1000000]
*/

using System;
using System.Collections.Generic;

namespace Task_10
{
    class Task_10
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            List<int> evenN = new List<int>();
            List<int> oddN = new List<int>();

            int prodEven = 1;
            int prodOdd = 1;

            // calculation
                // populate main list
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers.Add(x);
            }

                // populate even and odd lists
            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenN.Add(numbers[i - 1]);
                }
                else
                {
                    oddN.Add(numbers[i - 1]);
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
            if (prodEven == prodOdd)
            {
                Console.WriteLine($"yes {prodOdd}");
            }
            else
            {
                Console.WriteLine($"no {prodOdd} {prodEven}");
            }

        }
    }
}
