using System;
using System.Collections.Generic;

namespace PrimesToN
{
    class Program
    {
        static void Main(string[] args)
        {


            PrintPrimes(int.Parse(Console.ReadLine()));


        }


        static void PrintPrimes(int max)
        {
            
            // make and fill list with marked primes - Sieve of Eratophenes
            bool[] isPrime = new bool[max + 1];

            for (int i = 1; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

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

            // setting and filling the result 
            List<int> result = new List<int>();

            for (int k = 0; k < isPrime.Length; k++)
            {
                if (isPrime[k] == true)
                {
                    result.Add(k);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

/*
 * 3 5 7 9 11 13 15 17 19 21 23 25 27 29 31 33 35 37 39 41 43 45 47 49
 * 1 2 3 5 7 11 13 17 19 23 29 31 37
 */
