using System;
using System.Collections.Generic;

namespace Prime_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            string result = "";

            for (int i = 1; i <= n; i++)
            {
                for (int y = 2; y < i; y++)
                {
                    if (i % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result += "1";
                    Console.WriteLine(result);
                }
                else
                {
                    result += "0";
                }
                isPrime = true;
            }
        }
    }
}
