using System;

namespace _01_07_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int initSum = int.Parse(Console.ReadLine());

            double finalSum = initSum;

            // calculation and output
            for (int i = 1; i <= 3; i++)
            {
                finalSum += finalSum * 0.05;

                Console.WriteLine(finalSum.ToString("0.00"));
            }
        }
    }
}
