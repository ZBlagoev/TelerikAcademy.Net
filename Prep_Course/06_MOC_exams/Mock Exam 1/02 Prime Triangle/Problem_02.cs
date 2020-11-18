using System;

namespace _02_Prime_Triangle
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(Console.ReadLine());

            string result = "";

            // calculation
            for (int i = 1; i <= N; i++)
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
                    result += "1";
                    Console.WriteLine(result);
                }
                else
                {
                    result += "0";
                }

            }


        }
    }
}



