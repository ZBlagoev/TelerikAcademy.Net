using System;

namespace _03_10_Odd_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int sumE = 1;
            int sumO = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    sumE *= int.Parse(Console.ReadLine());
                }
                else
                {
                    sumO *= int.Parse(Console.ReadLine());
                }
            }

            // output
            if (sumE == sumO)
            {
                Console.WriteLine($"yes {sumE}");
            } 
            else
            {
                Console.WriteLine($"no {sumO} {sumE}");
            }
        }
    }
}
