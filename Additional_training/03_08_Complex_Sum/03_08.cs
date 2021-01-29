using System;

namespace _03_08_Complex_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());

            int factorial = 1;
            double sum = 1.0;

            // calculation
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;

                sum += factorial / Math.Pow(X, i);
            }

            // output
            Console.WriteLine(sum.ToString("0.00000"));

        }
    }
}
