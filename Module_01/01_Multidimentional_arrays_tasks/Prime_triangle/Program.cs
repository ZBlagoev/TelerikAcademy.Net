using System;
using System.Text;

namespace Prime_triangle
{
    class Program
    {
        static void Main(string[] args)
        {


            PrintPrimeTriangle(int.Parse(Console.ReadLine()));


        }

        static void PrintPrimeTriangle(int n)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Append("1");
                    Console.WriteLine(result.ToString());
                }
                else
                {
                    result.Append("0");
                }
            }
        }
    }
}
