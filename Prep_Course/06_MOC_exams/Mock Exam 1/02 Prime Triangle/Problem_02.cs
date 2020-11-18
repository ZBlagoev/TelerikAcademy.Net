using System;

namespace _02_Prime_Triangle
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            bool[] isPrime = new bool[n + 1];
            int biggestPrime = 0;

            string primes = "1";

                // initial fill of the array
            for (int i = 1; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

                // fill array with correct prime values
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    for (int j = 2; (i * j) < isPrime.Length; j++)
                    {
                        isPrime[i * j] = false;
                    }
                }
            }

            // calculation
            for (int i = 2; i < isPrime.Length; i++)
            {
                if(isPrime[i])
                {
                    primes += i.ToString();
                    biggestPrime = i;
                }
            }

            for (int i = 1; i <= biggestPrime; i++)
            {
                if (isPrime[i])
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (isPrime[j])
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    continue;
                }
                
            }

        }
    }
}



