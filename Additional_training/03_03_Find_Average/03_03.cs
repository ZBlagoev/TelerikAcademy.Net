using System;

namespace _03_03_Find_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                sum += number;
            }

            // output
            Console.WriteLine((sum / n).ToString("0.00"));
        }
    }
}
