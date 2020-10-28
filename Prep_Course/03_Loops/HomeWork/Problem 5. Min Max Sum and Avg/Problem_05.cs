using System;

namespace Problem_5._Min_Max_Sum_and_Avg
{
    class Problem_05
    {
        static void Main(string[] args)
        {
            //input 
            Console.WriteLine("Problem 5. Min, Max, Sum and Average of N Numbers");
            
            Console.Write("n: ");
            double n = double.Parse(Console.ReadLine());

            double k;
            double min = double.MaxValue;
            double max = double.MinValue;
            double average;
            double sum = 0.00;

            // calculation
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"n{i}: ");
                k = double.Parse(Console.ReadLine());
                sum += k;

                if (k < min)
                {
                    min = k;
                }

                if (k > max)
                {
                    max = k;
                }

            }

            average = sum / n;

            // output
            Console.WriteLine("output:");
            Console.WriteLine($"min={Math.Round(min, 2).ToString("#.00")}");
            Console.WriteLine($"max={Math.Round(max, 2).ToString("#.00")}");
            Console.WriteLine($"sum={Math.Round(sum, 2).ToString("#.00")}");
            Console.WriteLine($"avg={Math.Round(average, 2).ToString("#.00")}");
        }
    }
}
