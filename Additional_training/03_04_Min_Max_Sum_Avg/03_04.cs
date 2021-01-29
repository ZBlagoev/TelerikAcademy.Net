using System;

namespace _03_04_Min_Max_Sum_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (input >= max)
                {
                    max = input;
                }

                if (input < min)
                {
                    min = input;
                }

                sum += input;
            }

            // output
            Console.WriteLine($"min={min:0.00}");
            Console.WriteLine($"max={max:0.00}");
            Console.WriteLine($"sum={sum:0.00}");
            Console.WriteLine($"avg={sum/n:0.00}");
        }
    }
}
