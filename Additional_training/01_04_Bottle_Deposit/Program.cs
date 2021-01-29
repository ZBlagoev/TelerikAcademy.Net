using System;

namespace _01_04_Bottle_Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int bigBottles = int.Parse(Console.ReadLine());
            int smallBottles = int.Parse(Console.ReadLine());

            double sum = bigBottles * 0.25 + smallBottles * 0.1;

            Console.WriteLine(sum.ToString("0.00"));
        }
    }
}
