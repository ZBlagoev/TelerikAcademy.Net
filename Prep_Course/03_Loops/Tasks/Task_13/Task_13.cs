/*
Prime Factors
Write a program that finds the prime factors of a given non-prime number. 
List the factors in ascending order.

12 = 2 2 3
100 = 2 2 5 * 5
Input
On the first line you will receive one number - N
Output
Output each prime factor on a newline.
Constraints
4 <= N <= 1000
N is guaranteed to not be a prime
*/

using System;

namespace Task_13
{
    class Task_13
    {
        static void Main(string[] args)
        {
            // input
            int a = int.Parse(Console.ReadLine());

            // calculation and output
            for (int b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }

                    for (int i = x; i >= 1 ; i--)
                    {
                        Console.WriteLine(b);
                    }
                    
                }
            }

                
        }
    }
}
