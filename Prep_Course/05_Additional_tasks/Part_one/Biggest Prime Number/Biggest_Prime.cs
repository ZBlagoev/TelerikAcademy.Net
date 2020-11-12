/*
Description
Write a program that finds all prime numbers in the range [1 ... N]. 
Use the Sieve of Eratosthenes algorithm. The program should print 
the biggest prime number which is <= N.

Input
On the first line you will receive the number N
Output
Print the biggest prime number which is <= N
Constraints
2 <= N <= 10 000 000
*/
using System;

namespace Biggest_Prime_Number
{
    class Biggest_Prime
    {
        static void Main(string[] args)
        {
            // input
            bool[] isPrime = new bool[int.Parse(Console.ReadLine()) + 1];

            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            int prime = 0;

            // calculation
            for (int j = 2; j < isPrime.Length; j++)
            {
                if (isPrime[j])
                {
                    for (int p = 2; (p * j) < isPrime.Length; p++)
                    {
                        isPrime[p * j] = false;
                    }
                }
            }

            for (int k = 2; k < isPrime.Length; k++)
            {
                if (isPrime[k])
                {
                    prime = k;
                }
            }

            // output
            Console.WriteLine(prime);

        }
    }
}
