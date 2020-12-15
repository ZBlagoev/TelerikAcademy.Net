/*
Biggest Prime Number
Description
Write a program that finds all prime numbers in the range 1 ... N. Use the Sieve of Eratosthenes algorithm. 
The program should print the biggest prime number which is <= N.

Input
On the first line you will receive the number N
Output
Print the biggest prime number which is <= N
Constraints
2 <= N <= 10 000 000
*/

using System;

namespace Biggest_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BiggestPrime(int.Parse(Console.ReadLine())));
        }

        static int BiggestPrime(int numberUP)
        {
            bool[] isPrime = new bool[numberUP + 1];

            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            int result = 0;

            for (int j = 2; j < isPrime.Length; j++)
            {
                if (isPrime[j])
                {
                    for (int k = 2; (k * j) < isPrime.Length; k++)
                    {
                        isPrime[k * j] = false;
                    }
                }
            }

            for (int l = isPrime.Length - 1; l >= 2; l--)
            {
                result = l;

                if (isPrime[l] == true)
                {
                    break;
                }
            }

            return result;
        }
    }
}
