using System;

namespace Biggest_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(BiggestPrime(number));
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
